using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodeCommit
{
    /// <summary>Repository events that will cause the trigger to run actions in another service.</summary>
    [JsiiEnum("@aws-cdk/codecommit", "jsii$_aws_cdk_codecommit$.RepositoryEventTrigger")]
    public enum RepositoryEventTrigger
    {
        [JsiiEnumMember("All")]
        All,
        [JsiiEnumMember("UpdateRef")]
        UpdateRef,
        [JsiiEnumMember("CreateRef")]
        CreateRef,
        [JsiiEnumMember("DeleteRef")]
        DeleteRef
    }
}