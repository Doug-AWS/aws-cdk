using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CloudFront
{
    [JsiiInterfaceProxy("@aws-cdk/cloudfront", "jsii$_aws_cdk_cloudfront$.ErrorConfiguration")]
    public class ErrorConfigurationProxy : DeputyBase, IErrorConfiguration
    {
        private ErrorConfigurationProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The error code matched from the origin</summary>
        [JsiiProperty("originErrorCode", "{\"primitive\":\"number\"}")]
        public virtual double OriginErrorCode
        {
            get => GetProperty<double>();
            set => SetProperty(value);
        }

        /// <summary>The error code that is sent to the caller.</summary>
        [JsiiProperty("respondWithErrorCode", "{\"primitive\":\"number\"}")]
        public virtual double RespondWithErrorCode
        {
            get => GetProperty<double>();
            set => SetProperty(value);
        }

        /// <summary>The path to service instead</summary>
        [JsiiProperty("respondWithPage", "{\"primitive\":\"string\"}")]
        public virtual string RespondWithPage
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>How long before this error is retried.</summary>
        [JsiiProperty("cacheTtl", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? CacheTtl
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }
    }
}