using AWS.Cdk;
using AWS.Cdk.Resources.events.RuleResource;
using AWS.Cdk.Resources.iam;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Events
{
    public class EventRuleTarget : DeputyBase, IEventRuleTarget
    {
        /// <summary>
        /// A unique, user-defined identifier for the target. Acceptable values
        /// include alphanumeric characters, periods (.), hyphens (-), and
        /// underscores (_).
        /// </summary>
        [JsiiProperty("id", "{\"primitive\":\"string\"}", true)]
        public string Id
        {
            get;
            set;
        }

        /// <summary>The Amazon Resource Name (ARN) of the target.</summary>
        [JsiiProperty("arn", "{\"fqn\":\"jsii$_aws_cdk_core$.Arn\"}", true)]
        public Arn Arn
        {
            get;
            set;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management
        /// (IAM) role to use for this target when the rule is triggered. If one rule
        /// triggers multiple targets, you can use a different IAM role for each
        /// target.
        /// </summary>
        [JsiiProperty("roleArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.iam.RoleArn\",\"optional\":true}", true)]
        public RoleArn RoleArn
        {
            get;
            set;
        }

        /// <summary>
        /// The Amazon ECS task definition and task count to use, if the event target
        /// is an Amazon ECS task.
        /// </summary>
        [JsiiProperty("ecsParameters", "{\"fqn\":\"jsii$_aws_cdk_resources$.events.RuleResource.EcsParametersProperty\",\"optional\":true}", true)]
        public IEcsParametersProperty EcsParameters
        {
            get;
            set;
        }

        /// <summary>
        /// Settings that control shard assignment, when the target is a Kinesis
        /// stream. If you don't include this parameter, eventId is used as the
        /// partition key.
        /// </summary>
        [JsiiProperty("kinesisParameters", "{\"fqn\":\"jsii$_aws_cdk_resources$.events.RuleResource.KinesisParametersProperty\",\"optional\":true}", true)]
        public IKinesisParametersProperty KinesisParameters
        {
            get;
            set;
        }

        /// <summary>
        /// Parameters used when the rule invokes Amazon EC2 Systems Manager Run
        /// Command.
        /// </summary>
        [JsiiProperty("runCommandParameters", "{\"fqn\":\"jsii$_aws_cdk_resources$.events.RuleResource.RunCommandParametersProperty\",\"optional\":true}", true)]
        public IRunCommandParametersProperty RunCommandParameters
        {
            get;
            set;
        }
    }
}