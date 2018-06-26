using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Interface that is going to be implemented by constructs that you can load balance to</summary>
    [JsiiInterface("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.IClassicLoadBalancerTarget")]
    public interface IIClassicLoadBalancerTarget : IIConnectable
    {
        /// <summary>Attach load-balanced target to a classic ELB</summary>
        [JsiiMethod("attachToClassicLB", null, "[{\"name\":\"loadBalancer\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.ClassicLoadBalancer\"}}]")]
        void AttachToClassicLB(ClassicLoadBalancer loadBalancer);
    }
}