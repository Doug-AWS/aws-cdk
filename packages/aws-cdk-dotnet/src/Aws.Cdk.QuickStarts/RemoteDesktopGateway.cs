using Aws.Cdk;
using Aws.Cdk.Ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.QuickStarts
{
    /// <summary>Embed the Remote Desktop Gateway AWS QuickStart</summary>
    [JsiiClass("@aws-cdk/quickstarts", "jsii$_aws_cdk_quickstarts$.RemoteDesktopGateway", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_quickstarts$.RemoteDesktopGatewayProps\"}}]")]
    public class RemoteDesktopGateway : Construct, IIDefaultConnectable
    {
        public RemoteDesktopGateway(Construct parent, string name, IRemoteDesktopGatewayProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected RemoteDesktopGateway(ByRefValue reference): base(reference)
        {
        }

        protected RemoteDesktopGateway(DeputyProps props): base(props)
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