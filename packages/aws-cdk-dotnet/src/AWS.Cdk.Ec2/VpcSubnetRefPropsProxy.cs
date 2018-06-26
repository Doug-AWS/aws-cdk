using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcSubnetRefProps")]
    public class VpcSubnetRefPropsProxy : DeputyBase, IVpcSubnetRefProps
    {
        private VpcSubnetRefPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The Availability Zone the subnet is located in</summary>
        [JsiiProperty("availabilityZone", "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The subnetId for this particular subnet</summary>
        [JsiiProperty("subnetId", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetId\"}")]
        public virtual VpcSubnetId SubnetId
        {
            get => GetProperty<VpcSubnetId>();
            set => SetProperty(value);
        }
    }
}