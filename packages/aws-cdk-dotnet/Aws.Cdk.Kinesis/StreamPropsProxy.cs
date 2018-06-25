using Aws.Cdk.Kms;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Kinesis
{
    [JsiiInterfaceProxy("@aws-cdk/kinesis", "jsii$_aws_cdk_kinesis$.StreamProps")]
    public class StreamPropsProxy : DeputyBase, IStreamProps
    {
        private StreamPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Enforces a particular physical stream name.</summary>
        /// <remarks>default: &lt;generated&gt;</remarks>
        [JsiiProperty("streamName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string StreamName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The number of hours for the data records that are stored in shards to remain accessible.</summary>
        /// <remarks>default: 24</remarks>
        [JsiiProperty("retentionPeriodHours", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? RetentionPeriodHours
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>The number of shards for the stream.</summary>
        /// <remarks>default: 1</remarks>
        [JsiiProperty("shardCount", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? ShardCount
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// The kind of server-side encryption to apply to this stream.
        /// 
        /// If you choose KMS, you can specify a KMS key via `encryptionKey`. If
        /// encryption key is not specified, a key will automatically be created.
        /// </summary>
        /// <remarks>default: Unencrypted</remarks>
        [JsiiProperty("encryption", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Encryption
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// External KMS key to use for stream encryption.
        /// 
        /// The 'encryption' property must be set to "Kms".
        /// </summary>
        /// <remarks>
        /// default: If encryption is set to "Kms" and this property is undefined, a
        /// new KMS key will be created and associated with this stream.
        /// </remarks>
        [JsiiProperty("encryptionKey", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRef\",\"optional\":true}")]
        public virtual EncryptionKeyRef EncryptionKey
        {
            get => GetProperty<EncryptionKeyRef>();
            set => SetProperty(value);
        }
    }
}