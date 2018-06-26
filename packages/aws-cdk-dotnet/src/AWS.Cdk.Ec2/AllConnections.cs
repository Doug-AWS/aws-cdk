using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>All TCP Ports</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.AllConnections", "[]")]
    public class AllConnections : DeputyBase, IIPortRange
    {
        public AllConnections(): base(new DeputyProps(new object[]{}))
        {
        }

        protected AllConnections(ByRefValue reference): base(reference)
        {
        }

        protected AllConnections(DeputyProps props): base(props)
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