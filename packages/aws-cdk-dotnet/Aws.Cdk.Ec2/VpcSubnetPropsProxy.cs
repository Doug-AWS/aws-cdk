using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>Specify configuration parameters for a VPC subnet</summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcSubnetProps")]
    public class VpcSubnetPropsProxy : DeputyBase, IVpcSubnetProps
    {
        private VpcSubnetPropsProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("availabilityZone", "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("vpcId", "{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}")]
        public virtual Token VpcId
        {
            get => GetProperty<Token>();
            set => SetProperty(value);
        }

        [JsiiProperty("cidrBlock", "{\"primitive\":\"string\"}")]
        public virtual string CidrBlock
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("mapPublicIpOnLaunch", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? MapPublicIpOnLaunch
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }
    }
}