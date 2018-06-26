using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>The outbound traffic mode defines whether the VPC is configured to route outbound traffic.</summary>
    [JsiiEnum("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.OutboundTrafficMode")]
    public enum OutboundTrafficMode
    {
        [JsiiEnumMember("None")]
        None,
        [JsiiEnumMember("FromPublicSubnetsOnly")]
        FromPublicSubnetsOnly,
        [JsiiEnumMember("FromPublicAndPrivateSubnets")]
        FromPublicAndPrivateSubnets
    }
}