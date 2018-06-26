using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>
    /// Reference to a listener's port just created
    /// 
    /// This class exists to make it convenient to add port ranges to the load
    /// balancer's security group just for the port ranges that are involved in the
    /// listener.
    /// </summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.ClassicListenerPort", "[{\"name\":\"securityGroup\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.ISecurityGroup\"}},{\"name\":\"defaultPortRange\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}}]")]
    public class ClassicListenerPort : DeputyBase, IIDefaultConnectable
    {
        public ClassicListenerPort(IISecurityGroup securityGroup, IIPortRange defaultPortRange): base(new DeputyProps(new object[]{securityGroup, defaultPortRange}))
        {
        }

        protected ClassicListenerPort(ByRefValue reference): base(reference)
        {
        }

        protected ClassicListenerPort(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("connections", "{\"fqn\":\"jsii$_aws_cdk_ec2$.DefaultConnections\"}")]
        public virtual DefaultConnections Connections
        {
            get => GetProperty<DefaultConnections>();
        }

        [JsiiProperty("defaultPortRange", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}")]
        public virtual IIPortRange DefaultPortRange
        {
            get => GetProperty<IIPortRange>();
        }
    }
}