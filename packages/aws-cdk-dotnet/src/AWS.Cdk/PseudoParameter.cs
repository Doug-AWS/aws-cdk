using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.PseudoParameter", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PseudoParameter : Token
    {
        public PseudoParameter(string name): base(new DeputyProps(new object[]{name}))
        {
        }

        protected PseudoParameter(ByRefValue reference): base(reference)
        {
        }

        protected PseudoParameter(DeputyProps props): base(props)
        {
        }
    }
}