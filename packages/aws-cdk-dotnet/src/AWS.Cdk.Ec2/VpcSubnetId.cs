using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Id of a VPC Subnet</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcSubnetId", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class VpcSubnetId : Token
    {
        public VpcSubnetId(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected VpcSubnetId(ByRefValue reference): base(reference)
        {
        }

        protected VpcSubnetId(DeputyProps props): base(props)
        {
        }
    }
}