using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// A rule can include a RuleCondition property and must include an Assertions property.
    /// For each rule, you can define only one rule condition; you can define one or more asserts within the Assertions property.
    /// You define a rule condition and assertions by using rule-specific intrinsic functions.
    /// 
    /// You can use the following rule-specific intrinsic functions to define rule conditions and assertions:
    /// 
    ///   Fn::And
    ///   Fn::Contains
    ///   Fn::EachMemberEquals
    ///   Fn::EachMemberIn
    ///   Fn::Equals
    ///   Fn::If
    ///   Fn::Not
    ///   Fn::Or
    ///   Fn::RefAll
    ///   Fn::ValueOf
    ///   Fn::ValueOfAll
    /// 
    /// https://docs.aws.amazon.com/servicecatalog/latest/adminguide/reference-template_constraint_rules.html
    /// </summary>
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.RuleProps")]
    public class RulePropsProxy : DeputyBase, IRuleProps
    {
        private RulePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// If the rule condition evaluates to false, the rule doesn't take effect.
        /// If the function in the rule condition evaluates to true, expressions in each assert are evaluated and applied.
        /// </summary>
        [JsiiProperty("ruleCondition", "{\"fqn\":\"jsii$_aws_cdk_core$.Token\",\"optional\":true}")]
        public virtual Token RuleCondition
        {
            get => GetProperty<Token>();
            set => SetProperty(value);
        }

        /// <summary>Assertions which define the rule.</summary>
        [JsiiProperty("assertions", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_core$.RuleAssertion\"}},\"optional\":true}")]
        public virtual IRuleAssertion[] Assertions
        {
            get => GetProperty<IRuleAssertion[]>();
            set => SetProperty(value);
        }
    }
}