using AWS.Cdk.Resources.sns;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Properties of a Fleet</summary>
    [JsiiInterface("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.FleetProps")]
    public interface IFleetProps
    {
        /// <summary>Type of instance to launch</summary>
        [JsiiProperty("instanceType", "{\"fqn\":\"jsii$_aws_cdk_ec2$.InstanceType\"}")]
        InstanceType InstanceType
        {
            get;
            set;
        }

        /// <summary>Minimum number of instances in the fleet</summary>
        /// <remarks>default: 1</remarks>
        [JsiiProperty("minSize", "{\"primitive\":\"number\",\"optional\":true}")]
        double? MinSize
        {
            get;
            set;
        }

        /// <summary>Maximum number of instances in the fleet</summary>
        /// <remarks>default: 1</remarks>
        [JsiiProperty("maxSize", "{\"primitive\":\"number\",\"optional\":true}")]
        double? MaxSize
        {
            get;
            set;
        }

        /// <summary>Initial amount of instances in the fleet</summary>
        /// <remarks>default: 1</remarks>
        [JsiiProperty("desiredCapacity", "{\"primitive\":\"number\",\"optional\":true}")]
        double? DesiredCapacity
        {
            get;
            set;
        }

        /// <summary>Name of SSH keypair to grant access to instances</summary>
        /// <remarks>default: No SSH access will be possible</remarks>
        [JsiiProperty("keyName", "{\"primitive\":\"string\",\"optional\":true}")]
        string KeyName
        {
            get;
            set;
        }

        /// <summary>AMI to launch</summary>
        [JsiiProperty("machineImage", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IMachineImageSource\"}")]
        IIMachineImageSource MachineImage
        {
            get;
            set;
        }

        /// <summary>VPC to launch these instances in.</summary>
        [JsiiProperty("vpc", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}")]
        VpcNetworkRef Vpc
        {
            get;
            set;
        }

        /// <summary>Where to place instances within the VPC</summary>
        [JsiiProperty("vpcPlacement", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcPlacementStrategy\",\"optional\":true}")]
        IVpcPlacementStrategy VpcPlacement
        {
            get;
            set;
        }

        /// <summary>SNS topic to send notifications about fleet changes</summary>
        /// <remarks>default: No fleet change notifications will be sent.</remarks>
        [JsiiProperty("notificationsTopic", "{\"fqn\":\"jsii$_aws_cdk_resources$.sns.TopicResource\",\"optional\":true}")]
        TopicResource NotificationsTopic
        {
            get;
            set;
        }

        /// <summary>Whether the instances can initiate connections to anywhere by default</summary>
        /// <remarks>default: true</remarks>
        [JsiiProperty("allowAllOutbound", "{\"primitive\":\"boolean\",\"optional\":true}")]
        bool? AllowAllOutbound
        {
            get;
            set;
        }
    }
}