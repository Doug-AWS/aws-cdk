using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>Returns true if a specified string matches at least one value in a list of strings.</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnContains", "[{\"name\":\"listOfStrings\",\"type\":{\"primitive\":\"any\"}},{\"name\":\"value\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FnContains : FnCondition
    {
        public FnContains(object listOfStrings, string value): base(new DeputyProps(new object[]{listOfStrings, value}))
        {
        }

        protected FnContains(ByRefValue reference): base(reference)
        {
        }

        protected FnContains(DeputyProps props): base(props)
        {
        }
    }
}