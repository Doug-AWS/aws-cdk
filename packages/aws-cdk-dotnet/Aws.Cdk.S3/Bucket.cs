using Aws.Cdk;
using Aws.Cdk.Kms;
using Aws.Cdk.Resources.s3;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.S3
{
    /// <summary>
    /// An S3 bucket with associated policy objects
    /// 
    /// This bucket does not yet have all features that exposed by the underlying
    /// BucketResource.
    /// </summary>
    [JsiiClass("@aws-cdk/s3", "jsii$_aws_cdk_s3$.Bucket", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_s3$.BucketProps\",\"optional\":true}}]")]
    public class Bucket : BucketRef
    {
        public Bucket(Construct parent, string name, IBucketProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Bucket(ByRefValue reference): base(reference)
        {
        }

        protected Bucket(DeputyProps props): base(props)
        {
        }

        /// <summary>The ARN of the bucket.</summary>
        [JsiiProperty("bucketArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.s3.BucketArn\"}")]
        public override BucketArn BucketArn
        {
            get => GetProperty<BucketArn>();
        }

        /// <summary>The name of the bucket.</summary>
        [JsiiProperty("bucketName", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketName\"}")]
        public override BucketName BucketName
        {
            get => GetProperty<BucketName>();
        }

        [JsiiProperty("domainName", "{\"fqn\":\"jsii$_aws_cdk_resources$.s3.BucketDomainName\"}")]
        public virtual BucketDomainName DomainName
        {
            get => GetProperty<BucketDomainName>();
        }

        [JsiiProperty("dualstackDomainName", "{\"fqn\":\"jsii$_aws_cdk_resources$.s3.BucketDualStackDomainName\"}")]
        public virtual BucketDualStackDomainName DualstackDomainName
        {
            get => GetProperty<BucketDualStackDomainName>();
        }

        /// <summary>Optional KMS encryption key associated with this bucket.</summary>
        [JsiiProperty("encryptionKey", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRef\",\"optional\":true}")]
        public override EncryptionKeyRef EncryptionKey
        {
            get => GetProperty<EncryptionKeyRef>();
        }

        /// <summary>
        /// The resource policy assoicated with this bucket.
        /// 
        /// If `autoCreatePolicy` is true, a `BucketPolicy` will be created upon the
        /// first call to addToResourcePolicy(s).
        /// </summary>
        [JsiiProperty("policy", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketPolicy\",\"optional\":true}")]
        protected override BucketPolicy Policy
        {
            get => GetProperty<BucketPolicy>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Indicates if a bucket resource policy should automatically created upon
        /// the first call to `addToResourcePolicy`.
        /// </summary>
        [JsiiProperty("autoCreatePolicy", "{\"primitive\":\"boolean\"}")]
        protected override bool AutoCreatePolicy
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }

        /// <summary>Add a lifecycle rule to the bucket</summary>
        /// <param name = "rule">The rule to add</param>
        [JsiiMethod("addLifecycleRule", null, "[{\"name\":\"rule\",\"type\":{\"fqn\":\"jsii$_aws_cdk_s3$.LifecycleRule\"}}]")]
        public virtual void AddLifecycleRule(ILifecycleRule rule)
        {
            InvokeVoidMethod(new object[]{rule});
        }
    }
}