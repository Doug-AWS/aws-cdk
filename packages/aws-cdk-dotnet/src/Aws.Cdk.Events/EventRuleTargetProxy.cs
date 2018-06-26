using Aws.Cdk;
using Aws.Cdk.Resources.events.RuleResource;
using Aws.Cdk.Resources.iam;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Events
{
    [JsiiInterfaceProxy("@aws-cdk/events", "jsii$_aws_cdk_events$.EventRuleTarget")]
    public class EventRuleTargetProxy : DeputyBase, IEventRuleTarget
    {
        private EventRuleTargetProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// A unique, user-defined identifier for the target. Acceptable values
        /// include alphanumeric characters, periods (.), hyphens (-), and
        /// underscores (_).
        /// </summary>
        [JsiiProperty("id", "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The Amazon Resource Name (ARN) of the target.</summary>
        [JsiiProperty("arn", "{\"fqn\":\"jsii$_aws_cdk_core$.Arn\"}")]
        public virtual Arn Arn
        {
            get => GetProperty<Arn>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management
        /// (IAM) role to use for this target when the rule is triggered. If one rule
        /// triggers multiple targets, you can use a different IAM role for each
        /// target.
        /// </summary>
        [JsiiProperty("roleArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.iam.RoleArn\",\"optional\":true}")]
        public virtual RoleArn RoleArn
        {
            get => GetProperty<RoleArn>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The Amazon ECS task definition and task count to use, if the event target
        /// is an Amazon ECS task.
        /// </summary>
        [JsiiProperty("ecsParameters", "{\"fqn\":\"jsii$_aws_cdk_resources$.events.RuleResource.EcsParametersProperty\",\"optional\":true}")]
        public virtual IEcsParametersProperty EcsParameters
        {
            get => GetProperty<IEcsParametersProperty>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Settings that control shard assignment, when the target is a Kinesis
        /// stream. If you don't include this parameter, eventId is used as the
        /// partition key.
        /// </summary>
        [JsiiProperty("kinesisParameters", "{\"fqn\":\"jsii$_aws_cdk_resources$.events.RuleResource.KinesisParametersProperty\",\"optional\":true}")]
        public virtual IKinesisParametersProperty KinesisParameters
        {
            get => GetProperty<IKinesisParametersProperty>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Parameters used when the rule invokes Amazon EC2 Systems Manager Run
        /// Command.
        /// </summary>
        [JsiiProperty("runCommandParameters", "{\"fqn\":\"jsii$_aws_cdk_resources$.events.RuleResource.RunCommandParametersProperty\",\"optional\":true}")]
        public virtual IRunCommandParametersProperty RunCommandParameters
        {
            get => GetProperty<IRunCommandParametersProperty>();
            set => SetProperty(value);
        }
    }
}