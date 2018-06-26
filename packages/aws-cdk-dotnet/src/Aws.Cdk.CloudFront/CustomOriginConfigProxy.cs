using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CloudFront
{
    /// <summary>A custom origin configuration</summary>
    [JsiiInterfaceProxy("@aws-cdk/cloudfront", "jsii$_aws_cdk_cloudfront$.CustomOriginConfig")]
    public class CustomOriginConfigProxy : DeputyBase, ICustomOriginConfig
    {
        private CustomOriginConfigProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The domain name of the custom origin. Should not include the path - that should be in the parent SourceConfiguration</summary>
        [JsiiProperty("domainName", "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetProperty<string>();
        }

        /// <summary>The origin HTTP port</summary>
        /// <remarks>default: 80</remarks>
        [JsiiProperty("httpPort", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? HttpPort
        {
            get => GetProperty<double? >();
        }

        /// <summary>The origin HTTPS port</summary>
        /// <remarks>default: 443</remarks>
        [JsiiProperty("httpsPort", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? HttpsPort
        {
            get => GetProperty<double? >();
        }

        /// <summary>The keep alive timeout when making calls in seconds.</summary>
        /// <remarks>default: : 5 seconds</remarks>
        [JsiiProperty("originKeepaliveTimeoutSeconds", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? OriginKeepaliveTimeoutSeconds
        {
            get => GetProperty<double? >();
        }

        /// <summary>The protocol (http or https) policy to use when interacting with the origin.</summary>
        /// <remarks>default: : HttpsOnly</remarks>
        [JsiiProperty("originProtocolPolicy", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string OriginProtocolPolicy
        {
            get => GetProperty<string>();
        }

        /// <summary>The read timeout when calling the origin in seconds</summary>
        /// <remarks>default: 30 seconds</remarks>
        [JsiiProperty("originReadTimeoutSeconds", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? OriginReadTimeoutSeconds
        {
            get => GetProperty<double? >();
        }

        /// <summary>The SSL versions to use when interacting with the origin.</summary>
        /// <remarks>default: [TLSv1_2]</remarks>
        [JsiiProperty("allowedOriginSSLVersions", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cloudfront$.OriginSslPolicy\"}},\"optional\":true}")]
        public virtual OriginSslPolicy[] AllowedOriginSSLVersions
        {
            get => GetProperty<OriginSslPolicy[]>();
        }
    }
}