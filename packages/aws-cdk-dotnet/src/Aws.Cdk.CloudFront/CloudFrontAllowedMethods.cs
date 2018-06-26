using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CloudFront
{
    /// <summary>An enum for the supported methods to a CloudFront distribution.</summary>
    [JsiiEnum("@aws-cdk/cloudfront", "jsii$_aws_cdk_cloudfront$.CloudFrontAllowedMethods")]
    public enum CloudFrontAllowedMethods
    {
        [JsiiEnumMember("GET_HEAD")]
        GET_HEAD,
        [JsiiEnumMember("GET_HEAD_OPTIONS")]
        GET_HEAD_OPTIONS,
        [JsiiEnumMember("ALL")]
        ALL
    }
}