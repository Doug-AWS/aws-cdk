using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    /// <summary>Alias for Fn::Join('', [ values ]).</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnConcat", "[{\"name\":\"listOfValues\",\"type\":{\"primitive\":\"any\"}}]")]
    public class FnConcat : FnJoin
    {
        public FnConcat(object listOfValues): base(new DeputyProps(new object[]{listOfValues}))
        {
        }

        protected FnConcat(ByRefValue reference): base(reference)
        {
        }

        protected FnConcat(DeputyProps props): base(props)
        {
        }
    }
}