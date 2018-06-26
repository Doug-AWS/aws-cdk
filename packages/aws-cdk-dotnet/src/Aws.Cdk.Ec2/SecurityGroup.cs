using Aws.Cdk;
using Aws.Cdk.Resources.ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>
    /// Creates an Amazon EC2 security group within a VPC.
    /// 
    /// This class has an additional optimization over SecurityGroupRef that it can also create
    /// inline ingress and egress rule (which saves on the total number of resources inside
    /// the template).
    /// </summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.SecurityGroup", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.SecurityGroupProps\"}}]")]
    public class SecurityGroup : SecurityGroupRef
    {
        public SecurityGroup(Construct parent, string name, ISecurityGroupProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected SecurityGroup(ByRefValue reference): base(reference)
        {
        }

        protected SecurityGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>An attribute that represents the security group name.</summary>
        [JsiiProperty("groupName", "{\"fqn\":\"jsii$_aws_cdk_ec2$.SecurityGroupName\"}")]
        public virtual SecurityGroupName GroupName
        {
            get => GetProperty<SecurityGroupName>();
        }

        /// <summary>An attribute that represents the physical VPC ID this security group is part of.</summary>
        [JsiiProperty("vpcId", "{\"fqn\":\"jsii$_aws_cdk_resources$.ec2.SecurityGroupVpcId\"}")]
        public virtual SecurityGroupVpcId VpcId
        {
            get => GetProperty<SecurityGroupVpcId>();
        }

        [JsiiMethod("addIngressRule", null, "[{\"name\":\"peer\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectionPeer\"}},{\"name\":\"connection\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}},{\"name\":\"description\",\"type\":{\"primitive\":\"string\"}}]")]
        public override void AddIngressRule(IIConnectionPeer peer, IIPortRange connection, string description)
        {
            InvokeVoidMethod(new object[]{peer, connection, description});
        }

        [JsiiMethod("addEgressRule", null, "[{\"name\":\"peer\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectionPeer\"}},{\"name\":\"connection\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}},{\"name\":\"description\",\"type\":{\"primitive\":\"string\"}}]")]
        public override void AddEgressRule(IIConnectionPeer peer, IIPortRange connection, string description)
        {
            InvokeVoidMethod(new object[]{peer, connection, description});
        }
    }
}