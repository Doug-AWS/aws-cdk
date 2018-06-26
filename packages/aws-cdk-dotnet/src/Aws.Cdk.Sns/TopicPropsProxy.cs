using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sns
{
    /// <summary>Properties for a new SNS topic</summary>
    [JsiiInterfaceProxy("@aws-cdk/sns", "jsii$_aws_cdk_sns$.TopicProps")]
    public class TopicPropsProxy : DeputyBase, ITopicProps
    {
        private TopicPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>A developer-defined string that can be used to identify this SNS topic.</summary>
        /// <remarks>default: None</remarks>
        [JsiiProperty("displayName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string DisplayName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// A name for the topic.
        /// 
        /// If you don't specify a name, AWS CloudFormation generates a unique
        /// physical ID and uses that ID for the topic name. For more information,
        /// see Name Type.
        /// </summary>
        /// <remarks>default: Generated name</remarks>
        [JsiiProperty("topicName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string TopicName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}