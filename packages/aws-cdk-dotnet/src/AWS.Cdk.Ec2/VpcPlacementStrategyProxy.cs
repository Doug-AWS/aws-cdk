using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>
    /// Customize how instances are placed inside a VPC
    /// 
    /// Constructs that allow customization of VPC placement use parameters of this
    /// type to provide placement settings.
    /// </summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcPlacementStrategy")]
    public class VpcPlacementStrategyProxy : DeputyBase, IVpcPlacementStrategy
    {
        private VpcPlacementStrategyProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// Whether to use the VPC's public subnets to start instances
        /// 
        /// If false, the instances are started in the private subnets.
        /// </summary>
        /// <remarks>default: false</remarks>
        [JsiiProperty("usePublicSubnets", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? UsePublicSubnets
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }
    }
}