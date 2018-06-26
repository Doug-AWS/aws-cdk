using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>
    /// VpcNetwork deploys an AWS VPC, with public and private subnets per Availability Zone.
    /// For example:
    /// 
    /// import { VpcNetwork } from '@aws-cdk/ec2'
    /// 
    /// const vpc = new VpcNetwork(this, {
    ///      cidr: "10.0.0.0/16"
    /// })
    /// 
    /// // Iterate the public subnets
    /// for (let subnet of vpc.publicSubnets) {
    /// 
    /// }
    /// 
    /// // Iterate the private subnets
    /// for (let subnet of vpc.privateSubnets) {
    /// 
    /// }
    /// </summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcNetwork", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkProps\",\"optional\":true}}]")]
    public class VpcNetwork : VpcNetworkRef
    {
        public VpcNetwork(Construct parent, string name, IVpcNetworkProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected VpcNetwork(ByRefValue reference): base(reference)
        {
        }

        protected VpcNetwork(DeputyProps props): base(props)
        {
        }

        /// <summary>
        /// The default CIDR range used when creating VPCs.
        /// This can be overridden using VpcNetworkProps when creating a VPCNetwork resource.
        /// e.g. new VpcResource(this, { cidr: '192.168.0.0./16' })
        /// </summary>
        [JsiiProperty("DEFAULT_CIDR_RANGE", "{\"primitive\":\"string\"}")]
        public virtual string DEFAULT_CIDR_RANGE
        {
            get => GetProperty<string>();
        }

        /// <summary>Identifier for this VPC</summary>
        [JsiiProperty("vpcId", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkId\"}")]
        public override VpcNetworkId VpcId
        {
            get => GetProperty<VpcNetworkId>();
        }

        /// <summary>List of public subnets in this VPC</summary>
        [JsiiProperty("publicSubnets", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetRef\"}}}")]
        public override VpcSubnetRef[] PublicSubnets
        {
            get => GetProperty<VpcSubnetRef[]>();
        }

        /// <summary>List of private subnets in this VPC</summary>
        [JsiiProperty("privateSubnets", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetRef\"}}}")]
        public override VpcSubnetRef[] PrivateSubnets
        {
            get => GetProperty<VpcSubnetRef[]>();
        }

        /// <returns>The IPv4 CidrBlock as returned by the VPC</returns>
        [JsiiProperty("cidr", "{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}")]
        public virtual Token Cidr
        {
            get => GetProperty<Token>();
        }
    }
}