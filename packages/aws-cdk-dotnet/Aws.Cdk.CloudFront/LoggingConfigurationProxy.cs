using Aws.Cdk.S3;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CloudFront
{
    /// <summary>
    /// CloudFront supports logging of incoming requests and can log details to a given S3 Bucket.
    /// 
    /// If you wish to configure logging you can configure details about it.
    /// </summary>
    /// <remarks>default: prefix: no prefix is set by default.</remarks>
    [JsiiInterfaceProxy("@aws-cdk/cloudfront", "jsii$_aws_cdk_cloudfront$.LoggingConfiguration")]
    public class LoggingConfigurationProxy : DeputyBase, ILoggingConfiguration
    {
        private LoggingConfigurationProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("bucket", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\",\"optional\":true}")]
        public virtual BucketRef Bucket
        {
            get => GetProperty<BucketRef>();
        }

        [JsiiProperty("includeCookies", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? IncludeCookies
        {
            get => GetProperty<bool? >();
        }

        [JsiiProperty("prefix", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Prefix
        {
            get => GetProperty<string>();
        }
    }
}