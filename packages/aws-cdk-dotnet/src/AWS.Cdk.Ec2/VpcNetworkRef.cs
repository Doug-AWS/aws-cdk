using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>A new or imported VPC</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcNetworkRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class VpcNetworkRef : Construct, IIDependable
    {
        protected VpcNetworkRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected VpcNetworkRef(ByRefValue reference): base(reference)
        {
        }

        protected VpcNetworkRef(DeputyProps props): base(props)
        {
        }

        /// <summary>Identifier for this VPC</summary>
        [JsiiProperty("vpcId", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkId\"}")]
        public virtual VpcNetworkId VpcId
        {
            get => GetProperty<VpcNetworkId>();
        }

        /// <summary>List of public subnets in this VPC</summary>
        [JsiiProperty("publicSubnets", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetRef\"}}}")]
        public virtual VpcSubnetRef[] PublicSubnets
        {
            get => GetProperty<VpcSubnetRef[]>();
        }

        /// <summary>List of private subnets in this VPC</summary>
        [JsiiProperty("privateSubnets", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetRef\"}}}")]
        public virtual VpcSubnetRef[] PrivateSubnets
        {
            get => GetProperty<VpcSubnetRef[]>();
        }

        /// <summary>Parts of the VPC that constitute full construction</summary>
        [JsiiProperty("dependencyElements", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_core$.IDependable\"}}}")]
        public virtual IIDependable[] DependencyElements
        {
            get => GetProperty<IIDependable[]>();
        }

        /// <summary>Import an exported VPC</summary>
        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRefProps\"}}]")]
        public virtual VpcNetworkRef Import(Construct parent, string name, IVpcNetworkRefProps props)
        {
            return InvokeMethod<VpcNetworkRef>(new object[]{parent, name, props});
        }

        /// <summary>Return the subnets appropriate for the placement strategy</summary>
        [JsiiMethod("subnets", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcSubnetRef\"}}}", "[{\"name\":\"placement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcPlacementStrategy\",\"optional\":true}}]")]
        public virtual VpcSubnetRef[] Subnets(IVpcPlacementStrategy placement)
        {
            return InvokeMethod<VpcSubnetRef[]>(new object[]{placement});
        }

        /// <summary>Export this VPC from the stack</summary>
        [JsiiMethod("export", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRefProps\"}", "[]")]
        public virtual IVpcNetworkRefProps Export()
        {
            return InvokeMethod<IVpcNetworkRefProps>(new object[]{});
        }
    }
}