using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Interface for classes that provide the connection-specification parts of a security group rule</summary>
    [JsiiInterface("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.IPortRange")]
    public interface IIPortRange
    {
        [JsiiProperty("canInlineRule", "{\"primitive\":\"boolean\"}")]
        bool CanInlineRule
        {
            get;
        }

        /// <summary>Produce the ingress/egress rule JSON for the given connection</summary>
        [JsiiMethod("toRuleJSON", "{\"primitive\":\"any\"}", "[]")]
        object ToRuleJSON();
    }
}