using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sns
{
    [JsiiInterface("@aws-cdk/sns", "jsii$_aws_cdk_sns$.TopicPolicyProps")]
    public interface ITopicPolicyProps
    {
        /// <summary>The set of topics this policy applies to.</summary>
        [JsiiProperty("topics", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_sns$.TopicRef\"}}}")]
        TopicRef[] Topics
        {
            get;
            set;
        }
    }
}