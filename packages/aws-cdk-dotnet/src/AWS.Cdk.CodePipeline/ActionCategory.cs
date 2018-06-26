using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    [JsiiEnum("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.ActionCategory")]
    public enum ActionCategory
    {
        [JsiiEnumMember("Source")]
        Source,
        [JsiiEnumMember("Build")]
        Build,
        [JsiiEnumMember("Test")]
        Test,
        [JsiiEnumMember("Approval")]
        Approval,
        [JsiiEnumMember("Deploy")]
        Deploy,
        [JsiiEnumMember("Invoke")]
        Invoke
    }
}