using Aws.Cdk.Resources.cloudfront.DistributionResource;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CloudFront
{
    [JsiiInterfaceProxy("@aws-cdk/cloudfront", "jsii$_aws_cdk_cloudfront$.CloudFrontWebDistributionProps")]
    public class CloudFrontWebDistributionPropsProxy : DeputyBase, ICloudFrontWebDistributionProps
    {
        private CloudFrontWebDistributionPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>AliasConfiguration is used to configured CloudFront to respond to requests on custom domain names.</summary>
        /// <remarks>default: none</remarks>
        [JsiiProperty("aliasConfiguration", "{\"fqn\":\"jsii$_aws_cdk_cloudfront$.AliasConfiguration\",\"optional\":true}")]
        public virtual IAliasConfiguration AliasConfiguration
        {
            get => GetProperty<IAliasConfiguration>();
            set => SetProperty(value);
        }

        /// <summary>A comment for this distribution in the cloud front console.</summary>
        [JsiiProperty("comment", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Comment
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The default object to serve.</summary>
        /// <remarks>default: "index.html"</remarks>
        [JsiiProperty("defaultRootObject", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string DefaultRootObject
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>If your distribution should have IPv6 enabled.</summary>
        /// <remarks>default: true</remarks>
        [JsiiProperty("enableIpV6", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? EnableIpV6
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>The max supported HTTP Versions.</summary>
        /// <remarks>default: HttpVersion.HTTP2</remarks>
        [JsiiProperty("httpVersion", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string HttpVersion
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The price class for the distribution (this impacts how many locations CloudFront uses for your distribution, and billing)</summary>
        /// <remarks>default: PriceClass_100: the cheapest option for CloudFront is picked by default.</remarks>
        [JsiiProperty("priceClass", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string PriceClass
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The default viewer policy for incoming clients.</summary>
        /// <remarks>default: RedirectToHTTPs</remarks>
        [JsiiProperty("viewerProtocolPolicy", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string ViewerProtocolPolicy
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The origin configurations for this distribution. Behaviors are a part of the origin.</summary>
        [JsiiProperty("originConfigs", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cloudfront$.SourceConfiguration\"}}}")]
        public virtual ISourceConfiguration[] OriginConfigs
        {
            get => GetProperty<ISourceConfiguration[]>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Optional - if we should enable logging.
        /// You can pass an empty object ({}) to have us auto create a bucket for logging.
        /// Omission of this property indicates no logging is to be enabled.
        /// </summary>
        /// <remarks>default: : no logging is enabled by default.</remarks>
        [JsiiProperty("loggingConfig", "{\"fqn\":\"jsii$_aws_cdk_cloudfront$.LoggingConfiguration\",\"optional\":true}")]
        public virtual ILoggingConfiguration LoggingConfig
        {
            get => GetProperty<ILoggingConfiguration>();
            set => SetProperty(value);
        }

        /// <summary>How CloudFront should handle requests that are no successful (eg PageNotFound)</summary>
        [JsiiProperty("errorConfigurations", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_resources$.cloudfront.DistributionResource.CustomErrorResponseProperty\"}},\"optional\":true}")]
        public virtual ICustomErrorResponseProperty[] ErrorConfigurations
        {
            get => GetProperty<ICustomErrorResponseProperty[]>();
            set => SetProperty(value);
        }
    }
}