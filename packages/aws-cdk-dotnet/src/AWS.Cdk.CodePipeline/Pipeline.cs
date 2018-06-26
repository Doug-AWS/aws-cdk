using AWS.Cdk;
using AWS.Cdk.Events;
using AWS.Cdk.Iam;
using AWS.Cdk.S3;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    /// <summary>An AWS CodePipeline pipeline with its associated IAM role and S3 bucket.</summary>
    /// <remarks>
    /// example: // create a pipeline
    /// const pipeline = new Pipeline(this, 'Pipeline');
    /// 
    /// // add a stage
    /// const sourceStage = new Stage(pipeline, 'Source');
    /// 
    /// // add a source action to the stage
    /// new CodeCommitSource(sourceStage, 'Source', {
    /// artifactName: 'SourceArtifact',
    /// repository: repo
    /// });
    /// 
    /// // ... add more stages
    /// </remarks>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.Pipeline", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.PipelineProps\",\"optional\":true}}]")]
    public class Pipeline : Construct, IIEventRuleTarget
    {
        public Pipeline(Construct parent, string name, IPipelineProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Pipeline(ByRefValue reference): base(reference)
        {
        }

        protected Pipeline(DeputyProps props): base(props)
        {
        }

        /// <summary>
        /// The IAM role AWS CodePipeline will use to perform actions or assume roles for actions with
        /// a more specific IAM role.
        /// </summary>
        [JsiiProperty("role", "{\"fqn\":\"jsii$_aws_cdk_iam$.Role\"}")]
        public virtual Role Role
        {
            get => GetProperty<Role>();
        }

        /// <summary>ARN of this pipeline</summary>
        [JsiiProperty("pipelineArn", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.PipelineArn\"}")]
        public virtual PipelineArn PipelineArn
        {
            get => GetProperty<PipelineArn>();
        }

        /// <summary>Bucket used to store output artifacts</summary>
        [JsiiProperty("artifactBucket", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\"}")]
        public virtual BucketRef ArtifactBucket
        {
            get => GetProperty<BucketRef>();
        }

        /// <summary>
        /// Allows the pipeline to be used as a CloudWatch event rule target.
        /// 
        /// Usage:
        /// 
        ///       const pipeline = new Pipeline(this, 'MyPipeline');
        ///       const rule = new EventRule(this, 'MyRule', { schedule: 'rate(1 minute)' });
        ///       rule.addTarget(pipeline);
        /// </summary>
        [JsiiProperty("eventRuleTarget", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleTarget\"}")]
        public virtual IEventRuleTarget EventRuleTarget
        {
            get => GetProperty<IEventRuleTarget>();
        }

        /// <summary>Adds a statement to the pipeline role.</summary>
        [JsiiMethod("addToRolePolicy", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddToRolePolicy(PolicyStatement statement)
        {
            InvokeVoidMethod(new object[]{statement});
        }

        /// <summary>
        /// Defines an event rule triggered by the "CodePipeline Pipeline Execution
        /// State Change" event emitted from this pipeline.
        /// </summary>
        /// <param name = "name">
        /// The name of the event rule construct. If you wish to define
        /// more than a single onStateChange event, you will need to explicitly
        /// specify a name.
        /// </param>
        /// <param name = "target">
        /// Initial target to add to the event rule. You can also add
        /// targets and customize target inputs by calling `rule.addTarget(target[,
        ///      * options])` after the rule was created.
        /// </param>
        /// <param name = "options">Additional options to pass to the event rule</param>
        [JsiiMethod("onStateChange", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnStateChange(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>
        /// Validate the pipeline structure
        /// 
        /// Validation happens according to the rules documented at
        /// 
        /// https://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#pipeline-requirements
        /// </summary>
        /// <remarks>override: </remarks>
        [JsiiMethod("validate", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}", "[]")]
        public override string[] Validate()
        {
            return InvokeMethod<string[]>(new object[]{});
        }

        /// <summary>
        /// If a stage is added as a child, add it to the list of stages.
        /// TODO: This is a hack that should be removed once the CDK has an
        ///        onChildAdded type hook.
        /// </summary>
        /// <remarks>override: </remarks>
        [JsiiMethod("addChild", null, "[{\"name\":\"child\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
        protected override void AddChild(Construct child, string name)
        {
            InvokeVoidMethod(new object[]{child, name});
        }
    }
}