using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rds
{
    /// <summary>The engine for the database cluster</summary>
    [JsiiEnum("@aws-cdk/rds", "jsii$_aws_cdk_rds$.DatabaseClusterEngine")]
    public enum DatabaseClusterEngine
    {
        [JsiiEnumMember("Aurora")]
        Aurora,
        [JsiiEnumMember("Neptune")]
        Neptune
    }
}