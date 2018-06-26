using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sns
{
    /// <summary>Applies a policy to SNS topics.</summary>
    [JsiiClass("@aws-cdk/sns", "jsii$_aws_cdk_sns$.TopicPolicy", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_sns$.TopicPolicyProps\"}}]")]
    public class TopicPolicy : Construct
    {
        public TopicPolicy(Construct parent, string name, ITopicPolicyProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected TopicPolicy(ByRefValue reference): base(reference)
        {
        }

        protected TopicPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>The IAM policy document for this policy.</summary>
        [JsiiProperty("document", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyDocument\"}")]
        public virtual PolicyDocument Document
        {
            get => GetProperty<PolicyDocument>();
        }
    }
}