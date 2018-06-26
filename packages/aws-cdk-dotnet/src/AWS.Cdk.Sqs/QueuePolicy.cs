using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sqs
{
    /// <summary>Applies a policy to SQS queues.</summary>
    [JsiiClass("@aws-cdk/sqs", "jsii$_aws_cdk_sqs$.QueuePolicy", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_sqs$.QueuePolicyProps\"}}]")]
    public class QueuePolicy : Construct
    {
        public QueuePolicy(Construct parent, string name, IQueuePolicyProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected QueuePolicy(ByRefValue reference): base(reference)
        {
        }

        protected QueuePolicy(DeputyProps props): base(props)
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