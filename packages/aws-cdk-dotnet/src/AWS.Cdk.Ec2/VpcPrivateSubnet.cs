using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Represents a private VPC subnet resource</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcPrivateSubnet", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetProps\"}}]")]
    public class VpcPrivateSubnet : VpcSubnet
    {
        public VpcPrivateSubnet(Construct parent, string name, IVpcSubnetProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected VpcPrivateSubnet(ByRefValue reference): base(reference)
        {
        }

        protected VpcPrivateSubnet(DeputyProps props): base(props)
        {
        }

        /// <summary>Adds an entry to this subnets route table that points to the passed NATGatwayId</summary>
        [JsiiMethod("addDefaultNatRouteEntry", null, "[{\"name\":\"natGatewayId\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}}]")]
        public virtual void AddDefaultNatRouteEntry(Token natGatewayId)
        {
            InvokeVoidMethod(new object[]{natGatewayId});
        }
    }
}