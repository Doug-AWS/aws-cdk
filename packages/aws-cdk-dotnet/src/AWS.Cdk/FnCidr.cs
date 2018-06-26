using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    /// <summary>The intrinsic function Fn::Cidr returns the specified Cidr address block.</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnCidr", "[{\"name\":\"ipBlock\",\"type\":{\"primitive\":\"any\"}},{\"name\":\"count\",\"type\":{\"primitive\":\"any\"}},{\"name\":\"sizeMask\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class FnCidr : Fn
    {
        public FnCidr(object ipBlock, object count, object sizeMask): base(new DeputyProps(new object[]{ipBlock, count, sizeMask}))
        {
        }

        protected FnCidr(ByRefValue reference): base(reference)
        {
        }

        protected FnCidr(DeputyProps props): base(props)
        {
        }
    }
}