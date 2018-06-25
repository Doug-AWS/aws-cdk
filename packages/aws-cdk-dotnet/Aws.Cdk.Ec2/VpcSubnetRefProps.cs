using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    public class VpcSubnetRefProps : DeputyBase, IVpcSubnetRefProps
    {
        /// <summary>The Availability Zone the subnet is located in</summary>
        [JsiiProperty("availabilityZone", "{\"primitive\":\"string\"}", true)]
        public string AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>The subnetId for this particular subnet</summary>
        [JsiiProperty("subnetId", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetId\"}", true)]
        public VpcSubnetId SubnetId
        {
            get;
            set;
        }
    }
}