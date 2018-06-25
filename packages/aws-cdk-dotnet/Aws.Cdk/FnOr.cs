using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// Returns true if any one of the specified conditions evaluate to true, or returns false if
    /// all of the conditions evaluates to false. Fn::Or acts as an OR operator. The minimum number
    /// of conditions that you can include is 2, and the maximum is 10.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnOr", "[{\"name\":\"condition\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.FnCondition\"}}]")]
    public class FnOr : FnCondition
    {
        public FnOr(FnCondition condition): base(new DeputyProps(new object[]{condition}))
        {
        }

        protected FnOr(ByRefValue reference): base(reference)
        {
        }

        protected FnOr(DeputyProps props): base(props)
        {
        }
    }
}