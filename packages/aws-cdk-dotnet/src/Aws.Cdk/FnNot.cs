using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// Returns true for a condition that evaluates to false or returns false for a condition that evaluates to true.
    /// Fn::Not acts as a NOT operator.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnNot", "[{\"name\":\"condition\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.FnCondition\"}}]")]
    public class FnNot : FnCondition
    {
        public FnNot(FnCondition condition): base(new DeputyProps(new object[]{condition}))
        {
        }

        protected FnNot(ByRefValue reference): base(reference)
        {
        }

        protected FnNot(DeputyProps props): base(props)
        {
        }
    }
}