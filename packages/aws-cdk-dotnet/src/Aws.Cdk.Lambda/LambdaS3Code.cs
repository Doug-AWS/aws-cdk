using Aws.Cdk.Resources.lambda.FunctionResource;
using Aws.Cdk.S3;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Lambda
{
    [JsiiClass("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.LambdaS3Code", "[{\"name\":\"bucket\",\"type\":{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\"}},{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"objectVersion\",\"type\":{\"primitive\":\"string\",\"optional\":true}}]")]
    public class LambdaS3Code : LambdaCode
    {
        public LambdaS3Code(BucketRef bucket, string key, string objectVersion): base(new DeputyProps(new object[]{bucket, key, objectVersion}))
        {
        }

        protected LambdaS3Code(ByRefValue reference): base(reference)
        {
        }

        protected LambdaS3Code(DeputyProps props): base(props)
        {
        }

        [JsiiMethod("toJSON", "{\"fqn\":\"jsii$_aws_cdk_resources$.lambda.FunctionResource.CodeProperty\"}", "[{\"name\":\"_runtime\",\"type\":{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRuntime\"}}]")]
        public override ICodeProperty ToJSON(LambdaRuntime _runtime)
        {
            return InvokeMethod<ICodeProperty>(new object[]{_runtime});
        }
    }
}