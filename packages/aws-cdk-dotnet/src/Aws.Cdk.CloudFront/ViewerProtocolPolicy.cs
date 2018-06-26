using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CloudFront
{
    /// <summary>How HTTPs should be handled with your distribution.</summary>
    [JsiiEnum("@aws-cdk/cloudfront", "jsii$_aws_cdk_cloudfront$.ViewerProtocolPolicy")]
    public enum ViewerProtocolPolicy
    {
        [JsiiEnumMember("HTTPSOnly")]
        HTTPSOnly,
        [JsiiEnumMember("RedirectToHTTPS")]
        RedirectToHTTPS,
        [JsiiEnumMember("AllowAll")]
        AllowAll
    }
}