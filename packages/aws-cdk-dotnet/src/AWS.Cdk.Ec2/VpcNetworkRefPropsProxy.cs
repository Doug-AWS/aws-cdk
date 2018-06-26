using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Properties that reference an external VpcNetwork</summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcNetworkRefProps")]
    public class VpcNetworkRefPropsProxy : DeputyBase, IVpcNetworkRefProps
    {
        private VpcNetworkRefPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>VPC's identifier</summary>
        [JsiiProperty("vpcId", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkId\"}")]
        public virtual VpcNetworkId VpcId
        {
            get => GetProperty<VpcNetworkId>();
            set => SetProperty(value);
        }

        /// <summary>
        /// List of a availability zones, one for every subnet.
        /// 
        /// The first half are for the public subnets, the second half are for
        /// the private subnets.
        /// </summary>
        [JsiiProperty("availabilityZones", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}")]
        public virtual string[] AvailabilityZones
        {
            get => GetProperty<string[]>();
            set => SetProperty(value);
        }

        /// <summary>
        /// List of public subnet IDs, one for every subnet
        /// 
        /// Must match the availability zones and private subnet ids in length and order.
        /// </summary>
        [JsiiProperty("publicSubnetIds", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetId\"}}}")]
        public virtual VpcSubnetId[] PublicSubnetIds
        {
            get => GetProperty<VpcSubnetId[]>();
            set => SetProperty(value);
        }

        /// <summary>
        /// List of private subnet IDs, one for every subnet
        /// 
        /// Must match the availability zones and public subnet ids in length and order.
        /// </summary>
        [JsiiProperty("privateSubnetIds", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetId\"}}}")]
        public virtual VpcSubnetId[] PrivateSubnetIds
        {
            get => GetProperty<VpcSubnetId[]>();
            set => SetProperty(value);
        }
    }
}