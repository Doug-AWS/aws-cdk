using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Lambda
{
    /// <summary>Lambda function runtime environment.</summary>
    [JsiiEnum("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.LambdaRuntime")]
    public enum LambdaRuntime
    {
        [JsiiEnumMember("NodeJS")]
        NodeJS,
        [JsiiEnumMember("NodeJS43")]
        NodeJS43,
        [JsiiEnumMember("NodeJS43Edge")]
        NodeJS43Edge,
        [JsiiEnumMember("NodeJS610")]
        NodeJS610,
        [JsiiEnumMember("Java8")]
        Java8,
        [JsiiEnumMember("Python27")]
        Python27,
        [JsiiEnumMember("Python36")]
        Python36,
        [JsiiEnumMember("DotNetCore1")]
        DotNetCore1,
        [JsiiEnumMember("DotNetCore2")]
        DotNetCore2,
        [JsiiEnumMember("Go1x")]
        Go1x
    }
}