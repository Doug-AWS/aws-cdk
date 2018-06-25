using Aws.Cdk.Kms;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sqs
{
    /// <summary>Properties for creating a new Queue</summary>
    [JsiiInterfaceProxy("@aws-cdk/sqs", "jsii$_aws_cdk_sqs$.QueueProps")]
    public class QueuePropsProxy : DeputyBase, IQueueProps
    {
        private QueuePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// A name for the queue.
        /// 
        /// If specified and this is a FIFO queue, must end in the string '.fifo'.
        /// </summary>
        /// <remarks>default: CloudFormation-generated name</remarks>
        [JsiiProperty("queueName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string QueueName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The number of seconds that Amazon SQS retains a message.
        /// 
        /// You can specify an integer value from 60 seconds (1 minute) to 1209600
        /// seconds (14 days). The default value is 345600 seconds (4 days).
        /// </summary>
        /// <remarks>default: 345600 seconds (4 days)</remarks>
        [JsiiProperty("retentionPeriodSec", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? RetentionPeriodSec
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// The time in seconds that the delivery of all messages in the queue is delayed.
        /// 
        /// You can specify an integer value of 0 to 900 (15 minutes). The default
        /// value is 0.
        /// </summary>
        /// <remarks>default: 0</remarks>
        [JsiiProperty("deliveryDelaySec", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? DeliveryDelaySec
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// The limit of how many bytes that a message can contain before Amazon SQS rejects it.
        /// 
        /// You can specify an integer value from 1024 bytes (1 KiB) to 262144 bytes
        /// (256 KiB). The default value is 262144 (256 KiB).
        /// </summary>
        /// <remarks>default: 256KiB</remarks>
        [JsiiProperty("maxMessageSizeBytes", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MaxMessageSizeBytes
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// Default wait time for ReceiveMessage calls.
        /// 
        /// Does not wait if set to 0, otherwise waits this amount of seconds
        /// by default for messages to arrive.
        /// 
        /// For more information, see Amazon SQS Long Poll.
        /// 
        ///   
        /// </summary>
        /// <remarks>default: 0</remarks>
        [JsiiProperty("receiveMessageWaitTimeSec", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? ReceiveMessageWaitTimeSec
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// Timeout of processing a single message.
        /// 
        /// After dequeuing, the processor has this much time to handle the message
        /// and delete it from the queue before it becomes visible again for dequeueing
        /// by another processor.
        /// 
        /// Values must be from 0 to 43200 seconds (12 hours). If you don't specify
        /// a value, AWS CloudFormation uses the default value of 30 seconds.
        /// </summary>
        /// <remarks>default: 30</remarks>
        [JsiiProperty("visibilityTimeoutSec", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? VisibilityTimeoutSec
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>Send messages to this queue if they were unsuccessfully dequeued a number of times.</summary>
        /// <remarks>default: no dead-letter queue</remarks>
        [JsiiProperty("deadLetterQueue", "{\"fqn\":\"jsii$_aws_cdk_sqs$.DeadLetterQueue\",\"optional\":true}")]
        public virtual IDeadLetterQueue DeadLetterQueue
        {
            get => GetProperty<IDeadLetterQueue>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Whether the contents of the queue are encrypted, and by what type of key.
        /// 
        /// Be aware that encryption is not available in all regions, please see the docs
        /// for current availability details.
        /// </summary>
        /// <remarks>default: Unencrypted</remarks>
        [JsiiProperty("encryption", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Encryption
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// External KMS master key to use for queue encryption.
        /// 
        /// Individual messages will be encrypted using data keys. The data keys in
        /// turn will be encrypted using this key, and reused for a maximum of
        /// `dataKeyReuseSecs` seconds.
        /// 
        /// The 'encryption' property must be either not specified or set to "Kms".
        /// An error will be emitted if encryption is set to "Unencrypted" or
        /// "KmsManaged".
        /// </summary>
        /// <remarks>default: If encryption is set to KMS and not specified, a key will be created.</remarks>
        [JsiiProperty("encryptionMasterKey", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRef\",\"optional\":true}")]
        public virtual EncryptionKeyRef EncryptionMasterKey
        {
            get => GetProperty<EncryptionKeyRef>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The length of time that Amazon SQS reuses a data key before calling KMS again.
        /// 
        /// The value must be an integer between 60 (1 minute) and 86,400 (24
        /// hours). The default is 300 (5 minutes).
        /// </summary>
        /// <remarks>default: 300 (5 minutes)</remarks>
        [JsiiProperty("dataKeyReuseSec", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? DataKeyReuseSec
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>Whether this a first-in-first-out (FIFO) queue.</summary>
        /// <remarks>default: false, unless queueName ends in '.fifo' or 'contentBasedDeduplication' is true.</remarks>
        [JsiiProperty("fifo", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? Fifo
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// Specifies whether to enable content-based deduplication.
        /// 
        /// During the deduplication interval (5 minutes), Amazon SQS treats
        /// messages that are sent with identical content (excluding attributes) as
        /// duplicates and delivers only one copy of the message.
        /// 
        /// If you don't enable content-based deduplication and you want to deduplicate
        /// messages, provide an explicit deduplication ID in your SendMessage() call.
        /// 
        /// (Only applies to FIFO queues.)
        /// </summary>
        /// <remarks>default: false</remarks>
        [JsiiProperty("contentBasedDeduplication", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? ContentBasedDeduplication
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }
    }
}