using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    /// <summary>A rule assertion.</summary>
    [JsiiInterface("@aws-cdk/core", "jsii$_aws_cdk_core$.RuleAssertion")]
    public interface IRuleAssertion
    {
        /// <summary>The assertion.</summary>
        [JsiiProperty("assert", "{\"fqn\":\"jsii$_aws_cdk_core$.FnCondition\"}")]
        FnCondition Assert
        {
            get;
            set;
        }

        /// <summary>The assertion description.</summary>
        [JsiiProperty("assertDescription", "{\"primitive\":\"string\"}")]
        string AssertDescription
        {
            get;
            set;
        }
    }
}