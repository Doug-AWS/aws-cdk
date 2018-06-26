using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>The default tenancy of instances launched into the VPC.</summary>
    [JsiiEnum("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.DefaultInstanceTenancy")]
    public enum DefaultInstanceTenancy
    {
        [JsiiEnumMember("Default")]
        Default,
        [JsiiEnumMember("Dedicated")]
        Dedicated
    }
}