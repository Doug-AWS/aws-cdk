using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sns
{
    public class TopicPolicyProps : DeputyBase, ITopicPolicyProps
    {
        /// <summary>The set of topics this policy applies to.</summary>
        [JsiiProperty("topics", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_sns$.TopicRef\"}}}", true)]
        public TopicRef[] Topics
        {
            get;
            set;
        }
    }
}