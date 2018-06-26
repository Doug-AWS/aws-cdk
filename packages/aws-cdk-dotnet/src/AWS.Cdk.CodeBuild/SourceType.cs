using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodeBuild
{
    /// <summary>Source types for CodeBuild Project</summary>
    [JsiiEnum("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.SourceType")]
    public enum SourceType
    {
        [JsiiEnumMember("CodeCommit")]
        CodeCommit,
        [JsiiEnumMember("CodePipeline")]
        CodePipeline,
        [JsiiEnumMember("GitHub")]
        GitHub,
        [JsiiEnumMember("GitHubEnterPrise")]
        GitHubEnterPrise,
        [JsiiEnumMember("BitBucket")]
        BitBucket,
        [JsiiEnumMember("S3")]
        S3
    }
}