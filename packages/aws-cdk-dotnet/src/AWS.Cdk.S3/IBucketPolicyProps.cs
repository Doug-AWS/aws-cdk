using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.S3
{
    [JsiiInterface("@aws-cdk/s3", "jsii$_aws_cdk_s3$.BucketPolicyProps")]
    public interface IBucketPolicyProps
    {
        /// <summary>The Amazon S3 bucket that the policy applies to.</summary>
        [JsiiProperty("bucket", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\"}")]
        BucketRef Bucket
        {
            get;
            set;
        }
    }
}