using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>A class to orchestrate connections that already has default ports</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.DefaultConnections", "[{\"name\":\"securityGroup\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.ISecurityGroup\"}},{\"name\":\"defaultPortRangeProvider\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IDefaultConnectable\"}}]")]
    public class DefaultConnections : Connections
    {
        public DefaultConnections(IISecurityGroup securityGroup, IIDefaultConnectable defaultPortRangeProvider): base(new DeputyProps(new object[]{securityGroup, defaultPortRangeProvider}))
        {
        }

        protected DefaultConnections(ByRefValue reference): base(reference)
        {
        }

        protected DefaultConnections(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("defaultPortRange", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}")]
        public virtual IIPortRange DefaultPortRange
        {
            get => GetProperty<IIPortRange>();
        }

        /// <summary>
        /// Allow connections from the peer on our default port
        /// 
        /// Even if the peer has a default port, we will always use our default port.
        /// </summary>
        [JsiiMethod("allowDefaultPortFrom", null, "[{\"name\":\"other\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectable\"}},{\"name\":\"description\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual void AllowDefaultPortFrom(IIConnectable other, string description)
        {
            InvokeVoidMethod(new object[]{other, description});
        }

        /// <summary>Allow hosts inside the security group to connect to each other</summary>
        [JsiiMethod("allowDefaultPortInternally", null, "[{\"name\":\"description\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual void AllowDefaultPortInternally(string description)
        {
            InvokeVoidMethod(new object[]{description});
        }

        /// <summary>Allow default connections from all IPv4 ranges</summary>
        [JsiiMethod("allowDefaultPortFromAnyIpv4", null, "[{\"name\":\"description\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual void AllowDefaultPortFromAnyIpv4(string description)
        {
            InvokeVoidMethod(new object[]{description});
        }
    }
}