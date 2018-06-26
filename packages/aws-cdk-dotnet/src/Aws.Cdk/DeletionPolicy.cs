using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// With the DeletionPolicy attribute you can preserve or (in some cases) backup a resource when its stack is deleted.
    /// You specify a DeletionPolicy attribute for each resource that you want to control. If a resource has no DeletionPolicy
    /// attribute, AWS CloudFormation deletes the resource by default. Note that this capability also applies to update operations
    /// that lead to resources being removed.
    /// </summary>
    [JsiiEnum("@aws-cdk/core", "jsii$_aws_cdk_core$.DeletionPolicy")]
    public enum DeletionPolicy
    {
        [JsiiEnumMember("Delete")]
        Delete,
        [JsiiEnumMember("Retain")]
        Retain,
        [JsiiEnumMember("Snapshot")]
        Snapshot
    }
}