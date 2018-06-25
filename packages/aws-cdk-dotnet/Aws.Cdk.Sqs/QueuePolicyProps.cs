using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sqs
{
    public class QueuePolicyProps : DeputyBase, IQueuePolicyProps
    {
        /// <summary>The set of queues this policy applies to.</summary>
        [JsiiProperty("queues", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueRef\"}}}", true)]
        public QueueRef[] Queues
        {
            get;
            set;
        }
    }
}