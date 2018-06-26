using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>A TCP port range</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.TcpPortRange", "[{\"name\":\"startPort\",\"type\":{\"primitive\":\"number\"}},{\"name\":\"endPort\",\"type\":{\"primitive\":\"number\"}}]")]
    public class TcpPortRange : DeputyBase, IIPortRange
    {
        public TcpPortRange(double startPort, double endPort): base(new DeputyProps(new object[]{startPort, endPort}))
        {
        }

        protected TcpPortRange(ByRefValue reference): base(reference)
        {
        }

        protected TcpPortRange(DeputyProps props): base(props)
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