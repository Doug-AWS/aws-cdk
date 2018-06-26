using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.S3
{
    /// <summary>What kind of server-side encryption to apply to this bucket</summary>
    [JsiiEnum("@aws-cdk/s3", "jsii$_aws_cdk_s3$.BucketEncryption")]
    public enum BucketEncryption
    {
        [JsiiEnumMember("Unencrypted")]
        Unencrypted,
        [JsiiEnumMember("KmsManaged")]
        KmsManaged,
        [JsiiEnumMember("Kms")]
        Kms
    }
}