using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>A principal representing all identities in all accounts</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.Anyone", "[]")]
    public class Anyone : PolicyPrincipal
    {
        public Anyone(): base(new DeputyProps(new object[]{}))
        {
        }

        protected Anyone(ByRefValue reference): base(reference)
        {
        }

        protected Anyone(DeputyProps props): base(props)
        {
        }

        /// <summary>
        /// Interface compatibility with AccountPrincipal for the purposes of the Lambda library
        /// 
        /// The Lambda's addPermission() call works differently from regular
        /// statements, and will use the value of this property directly if present
        /// (which leads to the correct statement ultimately).
        /// </summary>
        [JsiiProperty("accountId", "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetProperty<string>();
        }

        /// <summary>Return the policy fragment that identifies this principal in a Policy.</summary>
        [JsiiMethod("policyFragment", "{\"fqn\":\"jsii$_aws_cdk_core$.PrincipalPolicyFragment\"}", "[]")]
        public override PrincipalPolicyFragment PolicyFragment()
        {
            return InvokeMethod<PrincipalPolicyFragment>(new object[]{});
        }
    }
}