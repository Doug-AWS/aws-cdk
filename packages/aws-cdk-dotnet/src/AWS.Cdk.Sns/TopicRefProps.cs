using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sns
{
    /// <summary>Reference to an external topic.</summary>
    public class TopicRefProps : DeputyBase, ITopicRefProps
    {
        [JsiiProperty("topicArn", "{\"fqn\":\"jsii$_aws_cdk_sns$.TopicArn\"}", true)]
        public TopicArn TopicArn
        {
            get;
            set;
        }
    }
}