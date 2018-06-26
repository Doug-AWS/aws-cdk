using AWS.Cdk.S3;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CloudFront
{
    /// <summary>
    /// CloudFront supports logging of incoming requests and can log details to a given S3 Bucket.
    /// 
    /// If you wish to configure logging you can configure details about it.
    /// </summary>
    /// <remarks>default: prefix: no prefix is set by default.</remarks>
    [JsiiInterface("@aws-cdk/cloudfront", "jsii$_aws_cdk_cloudfront$.LoggingConfiguration")]
    public interface ILoggingConfiguration
    {
        [JsiiProperty("bucket", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\",\"optional\":true}")]
        BucketRef Bucket
        {
            get;
        }

        [JsiiProperty("includeCookies", "{\"primitive\":\"boolean\",\"optional\":true}")]
        bool? IncludeCookies
        {
            get;
        }

        [JsiiProperty("prefix", "{\"primitive\":\"string\",\"optional\":true}")]
        string Prefix
        {
            get;
        }
    }
}