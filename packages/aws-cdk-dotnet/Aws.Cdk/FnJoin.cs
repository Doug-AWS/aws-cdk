using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// The intrinsic function Fn::Join appends a set of values into a single value, separated by
    /// the specified delimiter. If a delimiter is the empty string, the set of values are concatenated
    /// with no delimiter.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnJoin", "[{\"name\":\"delimiter\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"listOfValues\",\"type\":{\"primitive\":\"any\"}}]")]
    public class FnJoin : Fn
    {
        public FnJoin(string delimiter, object listOfValues): base(new DeputyProps(new object[]{delimiter, listOfValues}))
        {
        }

        protected FnJoin(ByRefValue reference): base(reference)
        {
        }

        protected FnJoin(DeputyProps props): base(props)
        {
        }
    }
}