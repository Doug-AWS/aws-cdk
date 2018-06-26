using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>A new or imported VPC Subnet</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcSubnetRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class VpcSubnetRef : Construct, IIDependable
    {
        protected VpcSubnetRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected VpcSubnetRef(ByRefValue reference): base(reference)
        {
        }

        protected VpcSubnetRef(DeputyProps props): base(props)
        {
        }

        /// <summary>The Availability Zone the subnet is located in</summary>
        [JsiiProperty("availabilityZone", "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetProperty<string>();
        }

        /// <summary>The subnetId for this particular subnet</summary>
        [JsiiProperty("subnetId", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetId\"}")]
        public virtual VpcSubnetId SubnetId
        {
            get => GetProperty<VpcSubnetId>();
        }

        /// <summary>Parts of this VPC subnet</summary>
        [JsiiProperty("dependencyElements", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_core$.IDependable\"}}}")]
        public virtual IIDependable[] DependencyElements
        {
            get => GetProperty<IIDependable[]>();
        }

        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetRefProps\"}}]")]
        public virtual VpcSubnetRef Import(Construct parent, string name, IVpcSubnetRefProps props)
        {
            return InvokeMethod<VpcSubnetRef>(new object[]{parent, name, props});
        }
    }
}