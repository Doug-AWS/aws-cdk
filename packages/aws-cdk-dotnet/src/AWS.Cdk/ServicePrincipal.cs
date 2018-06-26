using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    /// <summary>An IAM principal that represents an AWS service (i.e. sqs.amazonaws.com).</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.ServicePrincipal", "[{\"name\":\"service\",\"type\":{\"primitive\":\"any\"}}]")]
    public class ServicePrincipal : PolicyPrincipal
    {
        public ServicePrincipal(object service): base(new DeputyProps(new object[]{service}))
        {
        }

        protected ServicePrincipal(ByRefValue reference): base(reference)
        {
        }

        protected ServicePrincipal(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("service", "{\"primitive\":\"any\"}")]
        public virtual object Service
        {
            get => GetProperty<object>();
        }

        /// <summary>Return the policy fragment that identifies this principal in a Policy.</summary>
        [JsiiMethod("policyFragment", "{\"fqn\":\"jsii$_aws_cdk_core$.PrincipalPolicyFragment\"}", "[]")]
        public override PrincipalPolicyFragment PolicyFragment()
        {
            return InvokeMethod<PrincipalPolicyFragment>(new object[]{});
        }
    }
}