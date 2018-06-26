using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>Specify configuration parameters for a VPC subnet</summary>
    public class VpcSubnetProps : DeputyBase, IVpcSubnetProps
    {
        [JsiiProperty("availabilityZone", "{\"primitive\":\"string\"}", true)]
        public string AvailabilityZone
        {
            get;
            set;
        }

        [JsiiProperty("vpcId", "{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}", true)]
        public Token VpcId
        {
            get;
            set;
        }

        [JsiiProperty("cidrBlock", "{\"primitive\":\"string\"}", true)]
        public string CidrBlock
        {
            get;
            set;
        }

        [JsiiProperty("mapPublicIpOnLaunch", "{\"primitive\":\"boolean\",\"optional\":true}", true)]
        public bool? MapPublicIpOnLaunch
        {
            get;
            set;
        }
    }
}