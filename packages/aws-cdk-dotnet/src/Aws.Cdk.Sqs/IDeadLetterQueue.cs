using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sqs
{
    /// <summary>Dead letter queue settings</summary>
    [JsiiInterface("@aws-cdk/sqs", "jsii$_aws_cdk_sqs$.DeadLetterQueue")]
    public interface IDeadLetterQueue
    {
        /// <summary>The dead-letter queue to which Amazon SQS moves messages after the value of maxReceiveCount is exceeded.</summary>
        [JsiiProperty("queue", "{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueRef\"}")]
        QueueRef Queue
        {
            get;
            set;
        }

        /// <summary>The number of times a message can be unsuccesfully dequeued before being moved to the dead-letter queue.</summary>
        [JsiiProperty("maxReceiveCount", "{\"primitive\":\"number\"}")]
        double MaxReceiveCount
        {
            get;
            set;
        }
    }
}