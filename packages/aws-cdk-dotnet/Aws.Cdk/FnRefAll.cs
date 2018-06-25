using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>Returns all values for a specified parameter type.</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnRefAll", "[{\"name\":\"parameterType\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FnRefAll : FnCondition
    {
        public FnRefAll(string parameterType): base(new DeputyProps(new object[]{parameterType}))
        {
        }

        protected FnRefAll(ByRefValue reference): base(reference)
        {
        }

        protected FnRefAll(DeputyProps props): base(props)
        {
        }
    }
}