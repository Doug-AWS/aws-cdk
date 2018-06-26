using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Lambda
{
    [JsiiClass("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.FunctionName", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class FunctionName : Token
    {
        public FunctionName(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected FunctionName(ByRefValue reference): base(reference)
        {
        }

        protected FunctionName(DeputyProps props): base(props)
        {
        }
    }
}