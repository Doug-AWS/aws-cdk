using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>Any IPv6 address</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.AnyIPv6", "[]")]
    public class AnyIPv6 : CidrIpv6
    {
        public AnyIPv6(): base(new DeputyProps(new object[]{}))
        {
        }

        protected AnyIPv6(ByRefValue reference): base(reference)
        {
        }

        protected AnyIPv6(DeputyProps props): base(props)
        {
        }
    }
}