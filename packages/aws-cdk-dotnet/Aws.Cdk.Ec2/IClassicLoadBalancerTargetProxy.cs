using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>Interface that is going to be implemented by constructs that you can load balance to</summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.IClassicLoadBalancerTarget")]
    public class IClassicLoadBalancerTargetProxy : DeputyBase, IIClassicLoadBalancerTarget
    {
        private IClassicLoadBalancerTargetProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("connections", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnections\"}")]
        public virtual IIConnections Connections
        {
            get => GetProperty<IIConnections>();
        }

        /// <summary>Attach load-balanced target to a classic ELB</summary>
        [JsiiMethod("attachToClassicLB", null, "[{\"name\":\"loadBalancer\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.ClassicLoadBalancer\"}}]")]
        public virtual void AttachToClassicLB(ClassicLoadBalancer loadBalancer)
        {
            InvokeVoidMethod(new object[]{loadBalancer});
        }
    }
}