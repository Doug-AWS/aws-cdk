using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Kms
{
    [JsiiClass("@aws-cdk/kms", "jsii$_aws_cdk_kms$.AliasName", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class AliasName : Token
    {
        public AliasName(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected AliasName(ByRefValue reference): base(reference)
        {
        }

        protected AliasName(DeputyProps props): base(props)
        {
        }
    }
}