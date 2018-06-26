using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Represents a new VPC subnet resource</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcSubnet", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetProps\"}}]")]
    public class VpcSubnet : VpcSubnetRef
    {
        public VpcSubnet(Construct parent, string name, IVpcSubnetProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected VpcSubnet(ByRefValue reference): base(reference)
        {
        }

        protected VpcSubnet(DeputyProps props): base(props)
        {
        }

        /// <summary>The Availability Zone the subnet is located in</summary>
        [JsiiProperty("availabilityZone", "{\"primitive\":\"string\"}")]
        public override string AvailabilityZone
        {
            get => GetProperty<string>();
        }

        /// <summary>The subnetId for this particular subnet</summary>
        [JsiiProperty("subnetId", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetId\"}")]
        public override VpcSubnetId SubnetId
        {
            get => GetProperty<VpcSubnetId>();
        }

        [JsiiMethod("addDefaultRouteToNAT", null, "[{\"name\":\"natGatewayId\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}}]")]
        protected virtual void AddDefaultRouteToNAT(Token natGatewayId)
        {
            InvokeVoidMethod(new object[]{natGatewayId});
        }

        [JsiiMethod("addDefaultRouteToIGW", null, "[{\"name\":\"gatewayId\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}}]")]
        protected virtual void AddDefaultRouteToIGW(Token gatewayId)
        {
            InvokeVoidMethod(new object[]{gatewayId});
        }
    }
}