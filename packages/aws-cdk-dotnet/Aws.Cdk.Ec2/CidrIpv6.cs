using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>A connection to a from a given IPv6 range</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.CidrIpv6", "[{\"name\":\"cidrIpv6\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CidrIpv6 : DeputyBase, IIConnectionPeer, IIConnectable
    {
        public CidrIpv6(string cidrIpv6): base(new DeputyProps(new object[]{cidrIpv6}))
        {
        }

        protected CidrIpv6(ByRefValue reference): base(reference)
        {
        }

        protected CidrIpv6(DeputyProps props): base(props)
        {
        }

        /// <summary>Whether the rule can be inlined into a SecurityGroup or not</summary>
        [JsiiProperty("canInlineRule", "{\"primitive\":\"boolean\"}")]
        public virtual bool CanInlineRule
        {
            get => GetProperty<bool>();
        }

        [JsiiProperty("connections", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnections\"}")]
        public virtual IIConnections Connections
        {
            get => GetProperty<IIConnections>();
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