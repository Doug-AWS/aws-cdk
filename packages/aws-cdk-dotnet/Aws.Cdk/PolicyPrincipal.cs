using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>Represents an IAM principal.</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.PolicyPrincipal", "[]")]
    public abstract class PolicyPrincipal : DeputyBase
    {
        protected PolicyPrincipal(): base(new DeputyProps(new object[]{}))
        {
        }

        protected PolicyPrincipal(ByRefValue reference): base(reference)
        {
        }

        protected PolicyPrincipal(DeputyProps props): base(props)
        {
        }

        /// <summary>When this Principal is used in an AssumeRole policy, the action to use.</summary>
        [JsiiProperty("assumeRoleAction", "{\"primitive\":\"string\"}")]
        public virtual string AssumeRoleAction
        {
            get => GetProperty<string>();
        }

        /// <summary>Return the policy fragment that identifies this principal in a Policy.</summary>
        [JsiiMethod("policyFragment", "{\"fqn\":\"jsii$_aws_cdk_core$.PrincipalPolicyFragment\"}", "[]")]
        public abstract PrincipalPolicyFragment PolicyFragment();
    }
}