using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// Returns true if all the specified conditions evaluate to true, or returns false if any one
    ///   of the conditions evaluates to false. Fn::And acts as an AND operator. The minimum number of
    /// conditions that you can include is 2, and the maximum is 10.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnAnd", "[{\"name\":\"condition\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.FnCondition\"}}]")]
    public class FnAnd : FnCondition
    {
        public FnAnd(FnCondition condition): base(new DeputyProps(new object[]{condition}))
        {
        }

        protected FnAnd(ByRefValue reference): base(reference)
        {
        }

        protected FnAnd(DeputyProps props): base(props)
        {
        }
    }
}