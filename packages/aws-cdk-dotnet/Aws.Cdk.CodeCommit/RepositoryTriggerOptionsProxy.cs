using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeCommit
{
    /// <summary>Creates for a repository trigger to an SNS topic or Lambda function.</summary>
    [JsiiInterfaceProxy("@aws-cdk/codecommit", "jsii$_aws_cdk_codecommit$.RepositoryTriggerOptions")]
    public class RepositoryTriggerOptionsProxy : DeputyBase, IRepositoryTriggerOptions
    {
        private RepositoryTriggerOptionsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>A name for the trigger.Triggers on a repository must have unique names</summary>
        [JsiiProperty("name", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Name
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The repository events for which AWS CodeCommit sends information to the
        /// target, which you specified in the DestinationArn property.If you don't
        /// specify events, the trigger runs for all repository events.
        /// </summary>
        [JsiiProperty("events", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_codecommit$.RepositoryEventTrigger\"}},\"optional\":true}")]
        public virtual RepositoryEventTrigger[] Events
        {
            get => GetProperty<RepositoryEventTrigger[]>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The names of the branches in the AWS CodeCommit repository that contain
        /// events that you want to include in the trigger. If you don't specify at
        /// least one branch, the trigger applies to all branches.
        /// </summary>
        [JsiiProperty("branches", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}},\"optional\":true}")]
        public virtual string[] Branches
        {
            get => GetProperty<string[]>();
            set => SetProperty(value);
        }

        /// <summary>
        /// When an event is triggered, additional information that AWS CodeCommit
        /// includes when it sends information to the target.
        /// </summary>
        [JsiiProperty("customData", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string CustomData
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}