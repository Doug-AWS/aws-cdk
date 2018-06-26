using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>An object that has a Connections object as well as a default port range.</summary>
    public class IDefaultConnectable : DeputyBase, IIDefaultConnectable
    {
        [JsiiProperty("defaultPortRange", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}", true)]
        public IIPortRange DefaultPortRange
        {
            get;
        }

        [JsiiProperty("connections", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnections\"}", true)]
        public IIConnections Connections
        {
            get;
        }
    }
}