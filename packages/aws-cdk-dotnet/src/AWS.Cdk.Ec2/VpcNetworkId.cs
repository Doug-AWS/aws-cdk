using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Identifier for a VPC</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcNetworkId", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class VpcNetworkId : Token
    {
        public VpcNetworkId(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected VpcNetworkId(ByRefValue reference): base(reference)
        {
        }

        protected VpcNetworkId(DeputyProps props): base(props)
        {
        }
    }
}