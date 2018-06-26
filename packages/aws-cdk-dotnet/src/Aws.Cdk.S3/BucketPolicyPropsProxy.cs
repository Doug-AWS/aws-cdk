using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.S3
{
    [JsiiInterfaceProxy("@aws-cdk/s3", "jsii$_aws_cdk_s3$.BucketPolicyProps")]
    public class BucketPolicyPropsProxy : DeputyBase, IBucketPolicyProps
    {
        private BucketPolicyPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The Amazon S3 bucket that the policy applies to.</summary>
        [JsiiProperty("bucket", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\"}")]
        public virtual BucketRef Bucket
        {
            get => GetProperty<BucketRef>();
            set => SetProperty(value);
        }
    }
}