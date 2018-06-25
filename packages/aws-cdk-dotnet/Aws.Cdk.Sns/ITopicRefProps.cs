using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sns
{
    /// <summary>Reference to an external topic.</summary>
    [JsiiInterface("@aws-cdk/sns", "jsii$_aws_cdk_sns$.TopicRefProps")]
    public interface ITopicRefProps
    {
        [JsiiProperty("topicArn", "{\"fqn\":\"jsii$_aws_cdk_sns$.TopicArn\"}")]
        TopicArn TopicArn
        {
            get;
            set;
        }
    }
}