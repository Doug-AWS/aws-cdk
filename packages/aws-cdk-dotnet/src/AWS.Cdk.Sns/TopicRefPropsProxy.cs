using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sns
{
    /// <summary>Reference to an external topic.</summary>
    [JsiiInterfaceProxy("@aws-cdk/sns", "jsii$_aws_cdk_sns$.TopicRefProps")]
    public class TopicRefPropsProxy : DeputyBase, ITopicRefProps
    {
        private TopicRefPropsProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("topicArn", "{\"fqn\":\"jsii$_aws_cdk_sns$.TopicArn\"}")]
        public virtual TopicArn TopicArn
        {
            get => GetProperty<TopicArn>();
            set => SetProperty(value);
        }
    }
}