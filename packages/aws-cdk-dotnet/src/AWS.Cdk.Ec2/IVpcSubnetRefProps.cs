using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    [JsiiInterface("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcSubnetRefProps")]
    public interface IVpcSubnetRefProps
    {
        /// <summary>The Availability Zone the subnet is located in</summary>
        [JsiiProperty("availabilityZone", "{\"primitive\":\"string\"}")]
        string AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>The subnetId for this particular subnet</summary>
        [JsiiProperty("subnetId", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetId\"}")]
        VpcSubnetId SubnetId
        {
            get;
            set;
        }
    }
}