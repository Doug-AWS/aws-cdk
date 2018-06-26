using AWS.Cdk.Acm;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CloudFront
{
    /// <summary>
    /// CloudFront can use a custom domain that you provide instead of a "cloudfront.net" domain.
    /// To use this feature - you must provide the list of additional domains,
    /// and the ACM Certificate that CloudFront should use for these additional domains.
    /// 
    /// Note - CloudFront only accepts one additional certificate - therefore the certificate *must*
    /// use have SANs (Subject Alternative Names) for all domains listed.
    /// 
    /// sslMethod is optional - we default to SNI if not specified. See the notes on SSLMethod if you wish to use other SSL termination types.
    /// </summary>
    /// <remarks>default: sslMethod: SNI by default</remarks>
    [JsiiInterface("@aws-cdk/cloudfront", "jsii$_aws_cdk_cloudfront$.AliasConfiguration")]
    public interface IAliasConfiguration
    {
        [JsiiProperty("names", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}")]
        string[] Names
        {
            get;
        }

        [JsiiProperty("acmCertRef", "{\"fqn\":\"jsii$_aws_cdk_acm$.CertificateArn\"}")]
        CertificateArn AcmCertRef
        {
            get;
        }

        [JsiiProperty("sslMethod", "{\"primitive\":\"string\",\"optional\":true}")]
        string SslMethod
        {
            get;
        }
    }
}