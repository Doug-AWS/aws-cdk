using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sqs
{
    [JsiiInterfaceProxy("@aws-cdk/sqs", "jsii$_aws_cdk_sqs$.QueuePolicyProps")]
    public class QueuePolicyPropsProxy : DeputyBase, IQueuePolicyProps
    {
        private QueuePolicyPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The set of queues this policy applies to.</summary>
        [JsiiProperty("queues", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueRef\"}}}")]
        public virtual QueueRef[] Queues
        {
            get => GetProperty<QueueRef[]>();
            set => SetProperty(value);
        }
    }
}