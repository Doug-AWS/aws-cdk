using AWS.Cdk.Resources.cloudfront;
using AWS.Cdk.S3;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CloudFront
{
    [JsiiInterfaceProxy("@aws-cdk/cloudfront", "jsii$_aws_cdk_cloudfront$.S3OriginConfig")]
    public class S3OriginConfigProxy : DeputyBase, IS3OriginConfig
    {
        private S3OriginConfigProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The source bucket to serve content from</summary>
        [JsiiProperty("s3BucketSource", "{\"fqn\":\"jsii$_aws_cdk_s3$.Bucket\"}")]
        public virtual Bucket S3BucketSource
        {
            get => GetProperty<Bucket>();
        }

        /// <summary>The optional origin identity cloudfront will use when calling your s3 bucket.</summary>
        [JsiiProperty("originAccessIdentity", "{\"fqn\":\"jsii$_aws_cdk_resources$.cloudfront.CloudFrontOriginAccessIdentityResource\",\"optional\":true}")]
        public virtual CloudFrontOriginAccessIdentityResource OriginAccessIdentity
        {
            get => GetProperty<CloudFrontOriginAccessIdentityResource>();
        }
    }
}