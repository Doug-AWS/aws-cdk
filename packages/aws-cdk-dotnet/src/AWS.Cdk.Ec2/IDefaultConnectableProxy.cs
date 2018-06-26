using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>An object that has a Connections object as well as a default port range.</summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.IDefaultConnectable")]
    public class IDefaultConnectableProxy : DeputyBase, IIDefaultConnectable
    {
        private IDefaultConnectableProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("defaultPortRange", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}")]
        public virtual IIPortRange DefaultPortRange
        {
            get => GetProperty<IIPortRange>();
        }

        [JsiiProperty("connections", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnections\"}")]
        public virtual IIConnections Connections
        {
            get => GetProperty<IIConnections>();
        }
    }
}