using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Kinesis
{
    /// <summary>What kind of server-side encryption to apply to this stream</summary>
    [JsiiEnum("@aws-cdk/kinesis", "jsii$_aws_cdk_kinesis$.StreamEncryption")]
    public enum StreamEncryption
    {
        [JsiiEnumMember("Unencrypted")]
        Unencrypted,
        [JsiiEnumMember("Kms")]
        Kms
    }
}