using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.S3
{
    public class BucketPolicyProps : DeputyBase, IBucketPolicyProps
    {
        /// <summary>The Amazon S3 bucket that the policy applies to.</summary>
        [JsiiProperty("bucket", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\"}", true)]
        public BucketRef Bucket
        {
            get;
            set;
        }
    }
}