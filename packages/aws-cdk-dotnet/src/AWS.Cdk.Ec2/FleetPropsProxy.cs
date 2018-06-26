using AWS.Cdk.Resources.sns;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Properties of a Fleet</summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.FleetProps")]
    public class FleetPropsProxy : DeputyBase, IFleetProps
    {
        private FleetPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Type of instance to launch</summary>
        [JsiiProperty("instanceType", "{\"fqn\":\"jsii$_aws_cdk_ec2$.InstanceType\"}")]
        public virtual InstanceType InstanceType
        {
            get => GetProperty<InstanceType>();
            set => SetProperty(value);
        }

        /// <summary>Minimum number of instances in the fleet</summary>
        /// <remarks>default: 1</remarks>
        [JsiiProperty("minSize", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MinSize
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>Maximum number of instances in the fleet</summary>
        /// <remarks>default: 1</remarks>
        [JsiiProperty("maxSize", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MaxSize
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>Initial amount of instances in the fleet</summary>
        /// <remarks>default: 1</remarks>
        [JsiiProperty("desiredCapacity", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? DesiredCapacity
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>Name of SSH keypair to grant access to instances</summary>
        /// <remarks>default: No SSH access will be possible</remarks>
        [JsiiProperty("keyName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string KeyName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>AMI to launch</summary>
        [JsiiProperty("machineImage", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IMachineImageSource\"}")]
        public virtual IIMachineImageSource MachineImage
        {
            get => GetProperty<IIMachineImageSource>();
            set => SetProperty(value);
        }

        /// <summary>VPC to launch these instances in.</summary>
        [JsiiProperty("vpc", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}")]
        public virtual VpcNetworkRef Vpc
        {
            get => GetProperty<VpcNetworkRef>();
            set => SetProperty(value);
        }

        /// <summary>Where to place instances within the VPC</summary>
        [JsiiProperty("vpcPlacement", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcPlacementStrategy\",\"optional\":true}")]
        public virtual IVpcPlacementStrategy VpcPlacement
        {
            get => GetProperty<IVpcPlacementStrategy>();
            set => SetProperty(value);
        }

        /// <summary>SNS topic to send notifications about fleet changes</summary>
        /// <remarks>default: No fleet change notifications will be sent.</remarks>
        [JsiiProperty("notificationsTopic", "{\"fqn\":\"jsii$_aws_cdk_resources$.sns.TopicResource\",\"optional\":true}")]
        public virtual TopicResource NotificationsTopic
        {
            get => GetProperty<TopicResource>();
            set => SetProperty(value);
        }

        /// <summary>Whether the instances can initiate connections to anywhere by default</summary>
        /// <remarks>default: true</remarks>
        [JsiiProperty("allowAllOutbound", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? AllowAllOutbound
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }
    }
}