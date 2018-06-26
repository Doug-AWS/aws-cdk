using Aws.Cdk.Ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rds
{
    /// <summary>Instance properties for database instances</summary>
    public class InstanceProps : DeputyBase, IInstanceProps
    {
        /// <summary>What type of instance to start for the replicas</summary>
        [JsiiProperty("instanceType", "{\"fqn\":\"jsii$_aws_cdk_ec2$.InstanceType\"}", true)]
        public InstanceType InstanceType
        {
            get;
            set;
        }

        /// <summary>
        /// What subnets to run the RDS instances in.
        /// 
        /// Must be at least 2 subnets in two different AZs.
        /// </summary>
        [JsiiProperty("vpc", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}", true)]
        public VpcNetworkRef Vpc
        {
            get;
            set;
        }

        /// <summary>Where to place the instances within the VPC</summary>
        [JsiiProperty("vpcPlacement", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcPlacementStrategy\",\"optional\":true}", true)]
        public IVpcPlacementStrategy VpcPlacement
        {
            get;
            set;
        }
    }
}