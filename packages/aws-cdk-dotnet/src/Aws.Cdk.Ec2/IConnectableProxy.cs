using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>
    /// The goal of this module is to make possible to write statements like this:
    /// 
    ///     ```ts
    ///  *    database.connections.allowFrom(fleet);
    ///  *    fleet.connections.allowTo(database);
    ///  *    rdgw.connections.allowFromCidrIp('0.3.1.5/86');
    ///  *    rgdw.connections.allowTrafficTo(fleet, new AllPorts());
    ///  *    ```
    /// 
    /// The insight here is that some connecting peers have information on what ports should
    /// be involved in the connection, and some don't.
    /// 
    /// Constructs will make their `connections` property to be equal to an instance of
    /// either `Connections` or `ConnectionsWithDefault`.
    /// An object that has a Connections object
    /// </summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.IConnectable")]
    public class IConnectableProxy : DeputyBase, IIConnectable
    {
        private IConnectableProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("connections", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnections\"}")]
        public virtual IIConnections Connections
        {
            get => GetProperty<IIConnections>();
        }
    }
}