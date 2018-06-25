using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>Any IPv4 address</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.AnyIPv4", "[]")]
    public class AnyIPv4 : CidrIp
    {
        public AnyIPv4(): base(new DeputyProps(new object[]{}))
        {
        }

        protected AnyIPv4(ByRefValue reference): base(reference)
        {
        }

        protected AnyIPv4(DeputyProps props): base(props)
        {
        }
    }
}