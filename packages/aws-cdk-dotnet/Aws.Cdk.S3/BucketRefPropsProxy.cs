using Aws.Cdk.Resources.s3;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.S3
{
    /// <summary>
    /// A reference to a bucket. The easiest way to instantiate is to call
    /// `bucket.export()`. Then, the consumer can use `Bucket.import(this, ref)` and
    /// get a `Bucket`.
    /// </summary>
    [JsiiInterfaceProxy("@aws-cdk/s3", "jsii$_aws_cdk_s3$.BucketRefProps")]
    public class BucketRefPropsProxy : DeputyBase, IBucketRefProps
    {
        private BucketRefPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The ARN fo the bucket. At least one of bucketArn or bucketName must be
        /// defined in order to initialize a bucket ref.
        /// </summary>
        [JsiiProperty("bucketArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.s3.BucketArn\",\"optional\":true}")]
        public virtual BucketArn BucketArn
        {
            get => GetProperty<BucketArn>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The name of the bucket. If the underlying value of ARN is a string, the
        /// name will be parsed from the ARN. Otherwise, the name is optional, but
        /// some features that require the bucket name such as auto-creating a bucket
        /// policy, won't work.
        /// </summary>
        [JsiiProperty("bucketName", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketName\",\"optional\":true}")]
        public virtual BucketName BucketName
        {
            get => GetProperty<BucketName>();
            set => SetProperty(value);
        }
    }
}