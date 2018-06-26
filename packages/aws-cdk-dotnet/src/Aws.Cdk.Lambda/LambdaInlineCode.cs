using Aws.Cdk.Resources.lambda.FunctionResource;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Lambda
{
    [JsiiClass("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.LambdaInlineCode", "[{\"name\":\"code\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LambdaInlineCode : LambdaCode
    {
        public LambdaInlineCode(string code): base(new DeputyProps(new object[]{code}))
        {
        }

        protected LambdaInlineCode(ByRefValue reference): base(reference)
        {
        }

        protected LambdaInlineCode(DeputyProps props): base(props)
        {
        }

        [JsiiMethod("toJSON", "{\"fqn\":\"jsii$_aws_cdk_resources$.lambda.FunctionResource.CodeProperty\"}", "[{\"name\":\"runtime\",\"type\":{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRuntime\"}}]")]
        public override ICodeProperty ToJSON(LambdaRuntime runtime)
        {
            return InvokeMethod<ICodeProperty>(new object[]{runtime});
        }
    }
}