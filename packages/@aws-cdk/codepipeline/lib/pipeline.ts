import { Arn, Construct, PolicyStatement, RemovalPolicy, ServicePrincipal, Token } from '@aws-cdk/core';
import { EventRule, EventRuleProps, EventRuleTarget, IEventRuleTarget } from '@aws-cdk/events';
import * as iam from '@aws-cdk/iam';
import { Role } from '@aws-cdk/iam';
import { codepipeline } from '@aws-cdk/resources';
import { Bucket, BucketRef } from '@aws-cdk/s3';
import { flatMap, flatten } from '@aws-cdk/util';
import { Stage } from './stage';
import * as validation from './validation';

/**
 * The ARN of a pipeline
 */
export class PipelineArn extends Arn {
}

export interface PipelineProps {
    /**
     * The S3 bucket used by this Pipeline to store artifacts.
     * If not specified, a new S3 bucket will be created.
     */
    artifactBucket?: BucketRef;

    /**
     * Indicates whether to rerun the AWS CodePipeline pipeline after you update it.
     */
    restartExecutionOnUpdate?: boolean;

    /**
     * Name of the pipeline. If you don't specify a name,  AWS CloudFormation generates an ID
     * and uses that for the pipeline name.
     */
    pipelineName?: string;
}

/**
 * An AWS CodePipeline pipeline with its associated IAM role and S3 bucket.
 *
 * @example
 * // create a pipeline
 * const pipeline = new Pipeline(this, 'Pipeline');
 *
 * // add a stage
 * const sourceStage = new Stage(pipeline, 'Source');
 *
 * // add a source action to the stage
 * new CodeCommitSource(sourceStage, 'Source', {
 *     artifactName: 'SourceArtifact',
 *     repository: repo
 * });
 *
 * // ... add more stages
 */
export class Pipeline extends Construct implements IEventRuleTarget {
    /**
     * The IAM role AWS CodePipeline will use to perform actions or assume roles for actions with
     * a more specific IAM role.
     */
    public readonly role: iam.Role;

    /**
     * ARN of this pipeline
     */
    public readonly pipelineArn: PipelineArn;

    /**
     * Bucket used to store output artifacts
     */
    public readonly artifactBucket: BucketRef;

    private readonly stages = new Array<Stage>();
    private eventsRole?: Role;

    constructor(parent: Construct, name: string, props?: PipelineProps) {
        super(parent, name);
        props = props || {};

        validation.validateName('Pipeline', props.pipelineName);

        // If a bucket has been provided, use it - otherwise, create a bucket.
        let propsBucket = props.artifactBucket;
        if (!propsBucket) {
            propsBucket = new Bucket(this, 'ArtifactsBucket', {
                removalPolicy: RemovalPolicy.Orphan
            });
        }
        this.artifactBucket = propsBucket;

        this.role = new iam.Role(this, 'Role', {
            assumedBy: new ServicePrincipal('codepipeline.amazonaws.com')
        });

        const codePipeline = new codepipeline.PipelineResource(this, 'Resource', {
            artifactStore: new Token(() => this.renderArtifactStore()) as any,
            stages: new Token(() => this.renderStages()) as any,
            roleArn: this.role.roleArn,
            restartExecutionOnUpdate: props && props.restartExecutionOnUpdate,
            pipelineName: props && props.pipelineName,
        });

        // this will produce a DependsOn for both the role and the policy resources.
        codePipeline.addDependency(this.role);

        this.artifactBucket.grantReadWrite(this.role);

        // Does not expose a Fn::GetAtt for the ARN so we'll have to make it ourselves
        this.pipelineArn = new PipelineArn(Arn.fromComponents({
            service: 'codepipeline',
            resource: codePipeline.ref
        }));
    }

    /**
     * Adds a statement to the pipeline role.
     */
    public addToRolePolicy(statement: PolicyStatement) {
        this.role.addToPolicy(statement);
    }

    /**
     * Allows the pipeline to be used as a CloudWatch event rule target.
     *
     * Usage:
     *
     *      const pipeline = new Pipeline(this, 'MyPipeline');
     *      const rule = new EventRule(this, 'MyRule', { schedule: 'rate(1 minute)' });
     *      rule.addTarget(pipeline);
     *
     */
    public get eventRuleTarget(): EventRuleTarget {
        // the first time the event rule target is retrieved, we define an IAM
        // role assumable by the CloudWatch events service which is allowed to
        // start the execution of this pipeline. no need to define more than one
        // role per pipeline.
        if (!this.eventsRole) {
            this.eventsRole = new Role(this, 'EventsRole', {
                assumedBy: new ServicePrincipal('events.amazonaws.com')
            });

            this.eventsRole.addToPolicy(new PolicyStatement()
                .addResource(this.pipelineArn)
                .addAction('codepipeline:StartPipelineExecution'));
        }

        return {
            id: this.name,
            arn: this.pipelineArn,
            roleArn: this.eventsRole.roleArn,
        };
    }

    /**
     * Defines an event rule triggered by the "CodePipeline Pipeline Execution
     * State Change" event emitted from this pipeline.
     *
     * @param target Initial target to add to the event rule. You can also add
     * targets and customize target inputs by calling `rule.addTarget(target[,
     * options])` after the rule was created.
     *
     * @param options Additional options to pass to the event rule
     *
     * @param name The name of the event rule construct. If you wish to define
     * more than a single onStateChange event, you will need to explicitly
     * specify a name.
     */
    public onStateChange(name: string, target?: IEventRuleTarget, options?: EventRuleProps): EventRule {
        const rule = new EventRule(this, name, options);
        rule.addTarget(target);
        rule.addEventPattern({
            detailType: [ 'CodePipeline Pipeline Execution State Change' ],
            source: [ 'aws.codepipeline' ],
            resources: [ this.pipelineArn ],
        });
        return rule;
    }

    /**
     * Validate the pipeline structure
     *
     * Validation happens according to the rules documented at
     *
     * https://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#pipeline-requirements
     * @override
     */
    public validate(): string[] {
        return flatten([
            this.validateHasStages(),
            this.validateSourceActionLocations()
        ]);
    }

    /**
     * If a stage is added as a child, add it to the list of stages.
     * TODO: This is a hack that should be removed once the CDK has an
     *       onChildAdded type hook.
     * @override
     */
    protected addChild(child: Construct, name: string) {
        super.addChild(child, name);
        if (child instanceof Stage) {
            this.appendStage(child);
        }
    }

    private appendStage(stage: Stage) {
        if (this.stages.find(x => x.name === stage.name)) {
            throw new Error(`A stage with name '${stage.name}' already exists`);
        }

        this.stages.push(stage);
    }

    private validateSourceActionLocations(): string[] {
        return flatMap(this.stages, (stage, i) => {
            const onlySourceActionsPermitted = i === 0;
            return flatMap(stage.actions, (action, _) =>
                validation.validateSourceAction(onlySourceActionsPermitted, action.category, action.name, stage.name)
            );
        });
    }

    private validateHasStages(): string[] {
        if (this.stages.length < 2) {
            return ['Pipeline must have at least two stages'];
        }
        return [];
    }

    private renderArtifactStore(): codepipeline.PipelineResource.ArtifactStoreProperty {
        let encryptionKey: codepipeline.PipelineResource.EncryptionKeyProperty | undefined;
        const bucketKey = this.artifactBucket.encryptionKey;
        if (bucketKey) {
            encryptionKey = {
                type: 'KMS',
                id: bucketKey.keyArn,
            };
        }

        const bucketName = this.artifactBucket.bucketName;
        if (!bucketName) {
            throw new Error('Artifacts bucket must have a bucket name');
        }

        return {
            type: 'S3',
            location: bucketName,
            encryptionKey
        };
    }

    private renderStages(): codepipeline.PipelineResource.StageDeclarationProperty[] {
        return this.stages.map(stage => stage.render());
    }
}
