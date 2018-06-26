using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Protocol for use in Connection Rules</summary>
    [JsiiEnum("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.Protocol")]
    public enum Protocol
    {
        [JsiiEnumMember("All")]
        All,
        [JsiiEnumMember("Tcp")]
        Tcp,
        [JsiiEnumMember("Udp")]
        Udp,
        [JsiiEnumMember("Icmp")]
        Icmp,
        [JsiiEnumMember("Icmpv6")]
        Icmpv6
    }
}