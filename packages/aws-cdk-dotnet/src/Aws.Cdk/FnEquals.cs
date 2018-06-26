using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// Compares if two values are equal. Returns true if the two values are equal or false
    /// if they aren't.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnEquals", "[{\"name\":\"lhs\",\"type\":{\"primitive\":\"any\"}},{\"name\":\"rhs\",\"type\":{\"primitive\":\"any\"}}]")]
    public class FnEquals : FnCondition
    {
        public FnEquals(object lhs, object rhs): base(new DeputyProps(new object[]{lhs, rhs}))
        {
        }

        protected FnEquals(ByRefValue reference): base(reference)
        {
        }

        protected FnEquals(DeputyProps props): base(props)
        {
        }
    }
}