using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>
    /// An object that encapsulates connection logic
    /// 
    /// The IConnections object both has knowledge on what peer to use,
    /// as well as how to add connection rules.
    /// </summary>
    [JsiiInterface("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.IConnections")]
    public interface IIConnections
    {
        /// <summary>
        /// Access to the peer that we're connecting to
        /// 
        /// It's convenient to put this on the Connections object since
        /// all participants in this protocol have one anyway, and the Connections
        /// objects have access to it, so they don't need to implement two interfaces.
        /// </summary>
        [JsiiProperty("connectionPeer", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectionPeer\"}")]
        IIConnectionPeer ConnectionPeer
        {
            get;
        }

        /// <summary>Allow connections to the peer on the given port</summary>
        [JsiiMethod("allowTo", null, "[{\"name\":\"other\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectable\"}},{\"name\":\"portRange\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}},{\"name\":\"description\",\"type\":{\"primitive\":\"string\"}}]")]
        void AllowTo(IIConnectable other, IIPortRange portRange, string description);
        /// <summary>Allow connections from the peer on the given port</summary>
        [JsiiMethod("allowFrom", null, "[{\"name\":\"other\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectable\"}},{\"name\":\"portRange\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}},{\"name\":\"description\",\"type\":{\"primitive\":\"string\"}}]")]
        void AllowFrom(IIConnectable other, IIPortRange portRange, string description);
    }
}