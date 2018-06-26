using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sns
{
    /// <summary>Properties for creating a new subscription</summary>
    [JsiiInterface("@aws-cdk/sns", "jsii$_aws_cdk_sns$.SubscriptionProps")]
    public interface ISubscriptionProps
    {
        /// <summary>What type of subscription to add.</summary>
        [JsiiProperty("protocol", "{\"fqn\":\"jsii$_aws_cdk_sns$.SubscriptionProtocol\"}")]
        SubscriptionProtocol Protocol
        {
            get;
            set;
        }

        /// <summary>
        /// The subscription endpoint.
        /// 
        /// The meaning of this value depends on the value for 'protocol'.
        /// </summary>
        [JsiiProperty("endpoint", "{\"primitive\":\"any\"}")]
        object Endpoint
        {
            get;
            set;
        }

        /// <summary>The topic to subscribe to.</summary>
        [JsiiProperty("topic", "{\"fqn\":\"jsii$_aws_cdk_sns$.TopicRef\"}")]
        TopicRef Topic
        {
            get;
            set;
        }
    }
}