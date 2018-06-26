using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>A rule assertion.</summary>
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.RuleAssertion")]
    public class RuleAssertionProxy : DeputyBase, IRuleAssertion
    {
        private RuleAssertionProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The assertion.</summary>
        [JsiiProperty("assert", "{\"fqn\":\"jsii$_aws_cdk_core$.FnCondition\"}")]
        public virtual FnCondition Assert
        {
            get => GetProperty<FnCondition>();
            set => SetProperty(value);
        }

        /// <summary>The assertion description.</summary>
        [JsiiProperty("assertDescription", "{\"primitive\":\"string\"}")]
        public virtual string AssertDescription
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}