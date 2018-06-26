using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sqs
{
    [JsiiInterface("@aws-cdk/sqs", "jsii$_aws_cdk_sqs$.QueuePolicyProps")]
    public interface IQueuePolicyProps
    {
        /// <summary>The set of queues this policy applies to.</summary>
        [JsiiProperty("queues", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueRef\"}}}")]
        QueueRef[] Queues
        {
            get;
            set;
        }
    }
}