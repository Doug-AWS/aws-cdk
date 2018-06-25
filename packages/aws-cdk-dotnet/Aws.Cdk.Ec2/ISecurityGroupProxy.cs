using Aws.Cdk.Resources.ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>Basic interface for security groups</summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.ISecurityGroup")]
    public class ISecurityGroupProxy : DeputyBase, IISecurityGroup
    {
        private ISecurityGroupProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("securityGroupId", "{\"fqn\":\"jsii$_aws_cdk_resources$.ec2.SecurityGroupId\"}")]
        public virtual SecurityGroupId SecurityGroupId
        {
            get => GetProperty<SecurityGroupId>();
        }

        /// <summary>Whether the rule can be inlined into a SecurityGroup or not</summary>
        [JsiiProperty("canInlineRule", "{\"primitive\":\"boolean\"}")]
        public virtual bool CanInlineRule
        {
            get => GetProperty<bool>();
        }

        /// <summary>Whether the rule can be inlined into a SecurityGroup or not</summary>
        [JsiiProperty("canInlineRule", "{\"primitive\":\"boolean\"}")]
        public virtual bool CanInlineRule
        {
            get => GetProperty<bool>();
        }

        [JsiiMethod("addIngressRule", null, "[{\"name\":\"peer\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectionPeer\"}},{\"name\":\"connection\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}},{\"name\":\"description\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual void AddIngressRule(IIConnectionPeer peer, IIPortRange connection, string description)
        {
            InvokeVoidMethod(new object[]{peer, connection, description});
        }

        [JsiiMethod("addEgressRule", null, "[{\"name\":\"peer\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectionPeer\"}},{\"name\":\"connection\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}},{\"name\":\"description\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual void AddEgressRule(IIConnectionPeer peer, IIPortRange connection, string description)
        {
            InvokeVoidMethod(new object[]{peer, connection, description});
        }

        /// <summary>Produce the ingress rule JSON for the given connection</summary>
        [JsiiMethod("toIngressRuleJSON", "{\"primitive\":\"any\"}", "[]")]
        public virtual object ToIngressRuleJSON()
        {
            return InvokeMethod<object>(new object[]{});
        }

        /// <summary>Produce the egress rule JSON for the given connection</summary>
        [JsiiMethod("toEgressRuleJSON", "{\"primitive\":\"any\"}", "[]")]
        public virtual object ToEgressRuleJSON()
        {
            return InvokeMethod<object>(new object[]{});
        }
    }
}