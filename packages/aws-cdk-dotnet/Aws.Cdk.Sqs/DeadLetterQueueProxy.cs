using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sqs
{
    /// <summary>Dead letter queue settings</summary>
    [JsiiInterfaceProxy("@aws-cdk/sqs", "jsii$_aws_cdk_sqs$.DeadLetterQueue")]
    public class DeadLetterQueueProxy : DeputyBase, IDeadLetterQueue
    {
        private DeadLetterQueueProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The dead-letter queue to which Amazon SQS moves messages after the value of maxReceiveCount is exceeded.</summary>
        [JsiiProperty("queue", "{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueRef\"}")]
        public virtual QueueRef Queue
        {
            get => GetProperty<QueueRef>();
            set => SetProperty(value);
        }

        /// <summary>The number of times a message can be unsuccesfully dequeued before being moved to the dead-letter queue.</summary>
        [JsiiProperty("maxReceiveCount", "{\"primitive\":\"number\"}")]
        public virtual double MaxReceiveCount
        {
            get => GetProperty<double>();
            set => SetProperty(value);
        }
    }
}