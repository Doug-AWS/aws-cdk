using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sns
{
    [JsiiInterfaceProxy("@aws-cdk/sns", "jsii$_aws_cdk_sns$.TopicPolicyProps")]
    public class TopicPolicyPropsProxy : DeputyBase, ITopicPolicyProps
    {
        private TopicPolicyPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The set of topics this policy applies to.</summary>
        [JsiiProperty("topics", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_sns$.TopicRef\"}}}")]
        public virtual TopicRef[] Topics
        {
            get => GetProperty<TopicRef[]>();
            set => SetProperty(value);
        }
    }
}