using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>A single TCP port</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.TcpPort", "[{\"name\":\"port\",\"type\":{\"primitive\":\"number\"}}]")]
    public class TcpPort : DeputyBase, IIPortRange
    {
        public TcpPort(double port): base(new DeputyProps(new object[]{port}))
        {
        }

        protected TcpPort(ByRefValue reference): base(reference)
        {
        }

        protected TcpPort(DeputyProps props): base(props)
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