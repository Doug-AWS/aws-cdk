using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CloudFront
{
    /// <summary>The price class determines how many edge locations CloudFront will use for your distribution.</summary>
    [JsiiEnum("@aws-cdk/cloudfront", "jsii$_aws_cdk_cloudfront$.PriceClass")]
    public enum PriceClass
    {
        [JsiiEnumMember("PriceClass100")]
        PriceClass100,
        [JsiiEnumMember("PriceClass200")]
        PriceClass200,
        [JsiiEnumMember("PriceClassAll")]
        PriceClassAll
    }
}