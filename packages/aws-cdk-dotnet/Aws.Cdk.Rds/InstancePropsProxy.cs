using Aws.Cdk.Ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rds
{
    /// <summary>Instance properties for database instances</summary>
    [JsiiInterfaceProxy("@aws-cdk/rds", "jsii$_aws_cdk_rds$.InstanceProps")]
    public class InstancePropsProxy : DeputyBase, IInstanceProps
    {
        private InstancePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>What type of instance to start for the replicas</summary>
        [JsiiProperty("instanceType", "{\"fqn\":\"jsii$_aws_cdk_ec2$.InstanceType\"}")]
        public virtual InstanceType InstanceType
        {
            get => GetProperty<InstanceType>();
            set => SetProperty(value);
        }

        /// <summary>
        /// What subnets to run the RDS instances in.
        /// 
        /// Must be at least 2 subnets in two different AZs.
        /// </summary>
        [JsiiProperty("vpc", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}")]
        public virtual VpcNetworkRef Vpc
        {
            get => GetProperty<VpcNetworkRef>();
            set => SetProperty(value);
        }

        /// <summary>Where to place the instances within the VPC</summary>
        [JsiiProperty("vpcPlacement", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcPlacementStrategy\",\"optional\":true}")]
        public virtual IVpcPlacementStrategy VpcPlacement
        {
            get => GetProperty<IVpcPlacementStrategy>();
            set => SetProperty(value);
        }
    }
}