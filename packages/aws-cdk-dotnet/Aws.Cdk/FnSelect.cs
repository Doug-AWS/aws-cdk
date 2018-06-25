using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>The intrinsic function Fn::Select returns a single object from a list of objects by index.</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnSelect", "[{\"name\":\"index\",\"type\":{\"primitive\":\"number\"}},{\"name\":\"array\",\"type\":{\"primitive\":\"any\"}}]")]
    public class FnSelect : Fn
    {
        public FnSelect(double index, object array): base(new DeputyProps(new object[]{index, array}))
        {
        }

        protected FnSelect(ByRefValue reference): base(reference)
        {
        }

        protected FnSelect(DeputyProps props): base(props)
        {
        }
    }
}