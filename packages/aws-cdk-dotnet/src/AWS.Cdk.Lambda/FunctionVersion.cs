using AWS.Cdk.Resources.lambda;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Lambda
{
    /// <summary>A single version of a Lambda function</summary>
    [JsiiClass("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.FunctionVersion", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class FunctionVersion : AWS.Cdk.Resources.lambda.Version
    {
        public FunctionVersion(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected FunctionVersion(ByRefValue reference): base(reference)
        {
        }

        protected FunctionVersion(DeputyProps props): base(props)
        {
        }
    }
}