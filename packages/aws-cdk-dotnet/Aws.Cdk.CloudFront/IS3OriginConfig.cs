using Aws.Cdk.Resources.cloudfront;
using Aws.Cdk.S3;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CloudFront
{
    [JsiiInterface("@aws-cdk/cloudfront", "jsii$_aws_cdk_cloudfront$.S3OriginConfig")]
    public interface IS3OriginConfig
    {
        /// <summary>The source bucket to serve content from</summary>
        [JsiiProperty("s3BucketSource", "{\"fqn\":\"jsii$_aws_cdk_s3$.Bucket\"}")]
        Bucket S3BucketSource
        {
            get;
        }

        /// <summary>The optional origin identity cloudfront will use when calling your s3 bucket.</summary>
        [JsiiProperty("originAccessIdentity", "{\"fqn\":\"jsii$_aws_cdk_resources$.cloudfront.CloudFrontOriginAccessIdentityResource\",\"optional\":true}")]
        CloudFrontOriginAccessIdentityResource OriginAccessIdentity
        {
            get;
        }
    }
}