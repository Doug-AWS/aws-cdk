using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>Represents a public VPC subnet resource</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcPublicSubnet", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetProps\"}}]")]
    public class VpcPublicSubnet : VpcSubnet
    {
        public VpcPublicSubnet(Construct parent, string name, IVpcSubnetProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected VpcPublicSubnet(ByRefValue reference): base(reference)
        {
        }

        protected VpcPublicSubnet(DeputyProps props): base(props)
        {
        }

        /// <summary>Create a default route that points to a passed IGW</summary>
        [JsiiMethod("addDefaultIGWRouteEntry", null, "[{\"name\":\"gatewayId\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}}]")]
        public virtual void AddDefaultIGWRouteEntry(Token gatewayId)
        {
            InvokeVoidMethod(new object[]{gatewayId});
        }

        /// <summary>
        /// Creates a new managed NAT gateway attached to this public subnet.
        /// Also adds the EIP for the managed NAT.
        /// Returns the NAT Gateway ref
        /// </summary>
        [JsiiMethod("addNatGateway", "{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}", "[]")]
        public virtual Token AddNatGateway()
        {
            return InvokeMethod<Token>(new object[]{});
        }
    }
}