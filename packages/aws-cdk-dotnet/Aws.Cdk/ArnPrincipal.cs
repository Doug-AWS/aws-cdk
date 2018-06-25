using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.ArnPrincipal", "[{\"name\":\"arn\",\"type\":{\"primitive\":\"any\"}}]")]
    public class ArnPrincipal : PolicyPrincipal
    {
        public ArnPrincipal(object arn): base(new DeputyProps(new object[]{arn}))
        {
        }

        protected ArnPrincipal(ByRefValue reference): base(reference)
        {
        }

        protected ArnPrincipal(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("arn", "{\"primitive\":\"any\"}")]
        public virtual object Arn
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