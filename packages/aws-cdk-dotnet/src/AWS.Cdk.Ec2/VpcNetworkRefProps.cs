using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Properties that reference an external VpcNetwork</summary>
    public class VpcNetworkRefProps : DeputyBase, IVpcNetworkRefProps
    {
        /// <summary>VPC's identifier</summary>
        [JsiiProperty("vpcId", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkId\"}", true)]
        public VpcNetworkId VpcId
        {
            get;
            set;
        }

        /// <summary>
        /// List of a availability zones, one for every subnet.
        /// 
        /// The first half are for the public subnets, the second half are for
        /// the private subnets.
        /// </summary>
        [JsiiProperty("availabilityZones", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}", true)]
        public string[] AvailabilityZones
        {
            get;
            set;
        }

        /// <summary>
        /// List of public subnet IDs, one for every subnet
        /// 
        /// Must match the availability zones and private subnet ids in length and order.
        /// </summary>
        [JsiiProperty("publicSubnetIds", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetId\"}}}", true)]
        public VpcSubnetId[] PublicSubnetIds
        {
            get;
            set;
        }

        /// <summary>
        /// List of private subnet IDs, one for every subnet
        /// 
        /// Must match the availability zones and public subnet ids in length and order.
        /// </summary>
        [JsiiProperty("privateSubnetIds", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetId\"}}}", true)]
        public VpcSubnetId[] PrivateSubnetIds
        {
            get;
            set;
        }
    }
}