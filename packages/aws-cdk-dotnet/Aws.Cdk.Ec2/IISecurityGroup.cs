using Aws.Cdk.Resources.ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>Basic interface for security groups</summary>
    [JsiiInterface("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.ISecurityGroup")]
    public interface IISecurityGroup : IIConnectionPeer
    {
        [JsiiProperty("securityGroupId", "{\"fqn\":\"jsii$_aws_cdk_resources$.ec2.SecurityGroupId\"}")]
        SecurityGroupId SecurityGroupId
        {
            get;
        }

        /// <summary>Whether the rule can be inlined into a SecurityGroup or not</summary>
        [JsiiProperty("canInlineRule", "{\"primitive\":\"boolean\"}")]
        bool CanInlineRule
        {
            get;
        }

        [JsiiMethod("addIngressRule", null, "[{\"name\":\"peer\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectionPeer\"}},{\"name\":\"connection\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}},{\"name\":\"description\",\"type\":{\"primitive\":\"string\"}}]")]
        void AddIngressRule(IIConnectionPeer peer, IIPortRange connection, string description);
        [JsiiMethod("addEgressRule", null, "[{\"name\":\"peer\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectionPeer\"}},{\"name\":\"connection\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}},{\"name\":\"description\",\"type\":{\"primitive\":\"string\"}}]")]
        void AddEgressRule(IIConnectionPeer peer, IIPortRange connection, string description);
    }
}