using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Specify configuration parameters for a VPC subnet</summary>
    [JsiiInterface("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcSubnetProps")]
    public interface IVpcSubnetProps
    {
        [JsiiProperty("availabilityZone", "{\"primitive\":\"string\"}")]
        string AvailabilityZone
        {
            get;
            set;
        }

        [JsiiProperty("vpcId", "{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}")]
        Token VpcId
        {
            get;
            set;
        }

        [JsiiProperty("cidrBlock", "{\"primitive\":\"string\"}")]
        string CidrBlock
        {
            get;
            set;
        }

        [JsiiProperty("mapPublicIpOnLaunch", "{\"primitive\":\"boolean\",\"optional\":true}")]
        bool? MapPublicIpOnLaunch
        {
            get;
            set;
        }
    }
}