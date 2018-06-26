using AWS.Cdk.Resources.lambda.FunctionResource;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Lambda
{
    [JsiiClass("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.LambdaCode", "[]")]
    public abstract class LambdaCode : DeputyBase
    {
        protected LambdaCode(): base(new DeputyProps(new object[]{}))
        {
        }

        protected LambdaCode(ByRefValue reference): base(reference)
        {
        }

        protected LambdaCode(DeputyProps props): base(props)
        {
        }

        [JsiiMethod("toJSON", "{\"fqn\":\"jsii$_aws_cdk_resources$.lambda.FunctionResource.CodeProperty\"}", "[{\"name\":\"runtime\",\"type\":{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRuntime\"}}]")]
        public abstract ICodeProperty ToJSON(LambdaRuntime runtime);
    }
}