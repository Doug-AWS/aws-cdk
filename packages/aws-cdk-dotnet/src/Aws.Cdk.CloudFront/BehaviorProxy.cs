using Aws.Cdk.Resources.cloudfront.DistributionResource;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CloudFront
{
    /// <summary>A CloudFront behavior wrapper.</summary>
    [JsiiInterfaceProxy("@aws-cdk/cloudfront", "jsii$_aws_cdk_cloudfront$.Behavior")]
    public class BehaviorProxy : DeputyBase, IBehavior
    {
        private BehaviorProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>If CloudFront should automatically compress some content types.</summary>
        /// <remarks>default: true</remarks>
        [JsiiProperty("compress", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? Compress
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// If this behavior is the default behavior for the distribution.
        /// 
        /// You must specify exactly one default distribution per CloudFront distribution.
        /// The default behavior is allowed to omit the "path" property.
        /// </summary>
        [JsiiProperty("isDefaultBehavior", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? IsDefaultBehavior
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// Trusted signers is how CloudFront allows you to serve private content.
        /// The signers are the account IDs that are allowed to sign cookies/presigned URLs for this distribution.
        /// 
        /// If you pass a non empty value, all requests for this behavior must be signed (no public access will be allowed)
        /// </summary>
        [JsiiProperty("trustedSigners", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}},\"optional\":true}")]
        public virtual string[] TrustedSigners
        {
            get => GetProperty<string[]>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The default amount of time CloudFront will cache an object.
        /// 
        /// This value applies only when your custom origin does not add HTTP headers,
        /// such as Cache-Control max-age, Cache-Control s-maxage, and Expires to objects.
        /// </summary>
        /// <remarks>default: 86400 (1 day)</remarks>
        [JsiiProperty("defaultTtlSeconds", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? DefaultTtlSeconds
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>The method this CloudFront distribution responds do.</summary>
        /// <remarks>default: GET_HEAD</remarks>
        [JsiiProperty("allowedMethods", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string AllowedMethods
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The path this behavior responds to.
        /// Required for all non-default behaviors. (The default behavior implicitly has "*" as the path pattern. )
        /// </summary>
        [JsiiProperty("pathPattern", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string PathPattern
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Which methods are cached by CloudFront by default.</summary>
        /// <remarks>default: GET_HEAD</remarks>
        [JsiiProperty("cachedMethods", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string CachedMethods
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The values CloudFront will forward to the origin when making a request.</summary>
        /// <remarks>default: none (no cookies - no headers)</remarks>
        [JsiiProperty("forwardedValues", "{\"fqn\":\"jsii$_aws_cdk_resources$.cloudfront.DistributionResource.ForwardedValuesProperty\",\"optional\":true}")]
        public virtual IForwardedValuesProperty ForwardedValues
        {
            get => GetProperty<IForwardedValuesProperty>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The minimum amount of time that you want objects to stay in the cache
        /// before CloudFront queries your origin.
        /// </summary>
        [JsiiProperty("minTtlSeconds", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MinTtlSeconds
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// The max amount of time you want objects to stay in the cache
        /// before CloudFront queries your origin.
        /// </summary>
        /// <remarks>default: 31536000 (one year)</remarks>
        [JsiiProperty("maxTtlSeconds", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MaxTtlSeconds
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }
    }
}