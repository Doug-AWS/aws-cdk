using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>A single TCP port that is provided by a resource attribute</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.TcpPortFromAttribute", "[{\"name\":\"port\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}}]")]
    public class TcpPortFromAttribute : DeputyBase, IIPortRange
    {
        public TcpPortFromAttribute(Token port): base(new DeputyProps(new object[]{port}))
        {
        }

        protected TcpPortFromAttribute(ByRefValue reference): base(reference)
        {
        }

        protected TcpPortFromAttribute(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("canInlineRule", "{\"primitive\":\"boolean\"}")]
        public virtual bool CanInlineRule
        {
            get => GetProperty<bool>();
        }

        /// <summary>Produce the ingress/egress rule JSON for the given connection</summary>
        [JsiiMethod("toRuleJSON", "{\"primitive\":\"any\"}", "[]")]
        public virtual object ToRuleJSON()
        {
            return InvokeMethod<object>(new object[]{});
        }
    }
}