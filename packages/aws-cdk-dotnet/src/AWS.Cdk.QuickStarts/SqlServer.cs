using AWS.Cdk;
using AWS.Cdk.Ec2;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.QuickStarts
{
    /// <summary>An instance of Microsoft SQL server with associated security groups</summary>
    [JsiiClass("@aws-cdk/quickstarts", "jsii$_aws_cdk_quickstarts$.SqlServer", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_quickstarts$.SqlServerProps\"}}]")]
    public class SqlServer : Construct, IIConnectable
    {
        public SqlServer(Construct parent, string name, ISqlServerProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected SqlServer(ByRefValue reference): base(reference)
        {
        }

        protected SqlServer(DeputyProps props): base(props)
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