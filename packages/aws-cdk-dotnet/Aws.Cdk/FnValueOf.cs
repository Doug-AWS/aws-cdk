using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>Returns an attribute value or list of values for a specific parameter and attribute.</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnValueOf", "[{\"name\":\"parameterOrLogicalId\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"attribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FnValueOf : FnCondition
    {
        public FnValueOf(string parameterOrLogicalId, string attribute): base(new DeputyProps(new object[]{parameterOrLogicalId, attribute}))
        {
        }

        protected FnValueOf(ByRefValue reference): base(reference)
        {
        }

        protected FnValueOf(DeputyProps props): base(props)
        {
        }
    }
}