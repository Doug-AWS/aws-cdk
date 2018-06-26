using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sns
{
    /// <summary>Properties for creating a new subscription</summary>
    [JsiiInterfaceProxy("@aws-cdk/sns", "jsii$_aws_cdk_sns$.SubscriptionProps")]
    public class SubscriptionPropsProxy : DeputyBase, ISubscriptionProps
    {
        private SubscriptionPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>What type of subscription to add.</summary>
        [JsiiProperty("protocol", "{\"fqn\":\"jsii$_aws_cdk_sns$.SubscriptionProtocol\"}")]
        public virtual SubscriptionProtocol Protocol
        {
            get => GetProperty<SubscriptionProtocol>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The subscription endpoint.
        /// 
        /// The meaning of this value depends on the value for 'protocol'.
        /// </summary>
        [JsiiProperty("endpoint", "{\"primitive\":\"any\"}")]
        public virtual object Endpoint
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }

        /// <summary>The topic to subscribe to.</summary>
        [JsiiProperty("topic", "{\"fqn\":\"jsii$_aws_cdk_sns$.TopicRef\"}")]
        public virtual TopicRef Topic
        {
            get => GetProperty<TopicRef>();
            set => SetProperty(value);
        }
    }
}