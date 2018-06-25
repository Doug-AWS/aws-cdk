using Aws.Cdk.Kms;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.S3
{
    [JsiiInterfaceProxy("@aws-cdk/s3", "jsii$_aws_cdk_s3$.BucketProps")]
    public class BucketPropsProxy : DeputyBase, IBucketProps
    {
        private BucketPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The kind of server-side encryption to apply to this bucket.
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
        /// External KMS key to use for bucket encryption.
        /// 
        /// The 'encryption' property must be either not specified or set to "Kms".
        /// An error will be emitted if encryption is set to "Unencrypted" or
        /// "Managed".
        /// </summary>
        /// <remarks>
        /// default: If encryption is set to "Kms" and this property is undefined, a
        /// new KMS key will be created and associated with this bucket.
        /// </remarks>
        [JsiiProperty("encryptionKey", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRef\",\"optional\":true}")]
        public virtual EncryptionKeyRef EncryptionKey
        {
            get => GetProperty<EncryptionKeyRef>();
            set => SetProperty(value);
        }

        /// <summary>Physical name of this bucket.</summary>
        /// <remarks>default: Assigned by CloudFormation (recommended)</remarks>
        [JsiiProperty("bucketName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string BucketName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Policy to apply when the bucket is removed from this stack.</summary>
        /// <remarks>default: By default, the bucket will be destroyed if it is removed from the stack.</remarks>
        [JsiiProperty("removalPolicy", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? RemovalPolicy
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>The bucket policy associated with this bucket.</summary>
        /// <remarks>
        /// default: A bucket policy will be created automatically in the first call
        /// to addToPolicy.
        /// </remarks>
        [JsiiProperty("policy", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketPolicy\",\"optional\":true}")]
        public virtual BucketPolicy Policy
        {
            get => GetProperty<BucketPolicy>();
            set => SetProperty(value);
        }

        /// <summary>Whether this bucket should have versioning turned on or not.</summary>
        /// <remarks>default: false</remarks>
        [JsiiProperty("versioned", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? Versioned
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>Rules that define how Amazon S3 manages objects during their lifetime.</summary>
        /// <remarks>default: No lifecycle rules</remarks>
        [JsiiProperty("lifecycleRules", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_s3$.LifecycleRule\"}},\"optional\":true}")]
        public virtual ILifecycleRule[] LifecycleRules
        {
            get => GetProperty<ILifecycleRule[]>();
            set => SetProperty(value);
        }
    }
}