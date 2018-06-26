using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.S3
{
    /// <summary>Storage class to move an object to</summary>
    [JsiiEnum("@aws-cdk/s3", "jsii$_aws_cdk_s3$.StorageClass")]
    public enum StorageClass
    {
        [JsiiEnumMember("InfrequentAccess")]
        InfrequentAccess,
        [JsiiEnumMember("OneZoneInfrequentAccess")]
        OneZoneInfrequentAccess,
        [JsiiEnumMember("Glacier")]
        Glacier
    }
}