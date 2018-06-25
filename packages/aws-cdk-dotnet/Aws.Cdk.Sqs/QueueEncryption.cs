using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sqs
{
    /// <summary>What kind of encryption to apply to this queue</summary>
    [JsiiEnum("@aws-cdk/sqs", "jsii$_aws_cdk_sqs$.QueueEncryption")]
    public enum QueueEncryption
    {
        [JsiiEnumMember("Unencrypted")]
        Unencrypted,
        [JsiiEnumMember("KmsManaged")]
        KmsManaged,
        [JsiiEnumMember("Kms")]
        Kms
    }
}