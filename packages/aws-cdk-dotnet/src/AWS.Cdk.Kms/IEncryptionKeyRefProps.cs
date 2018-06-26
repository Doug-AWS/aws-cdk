using AWS.Cdk.Resources.kms;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Kms
{
    [JsiiInterface("@aws-cdk/kms", "jsii$_aws_cdk_kms$.EncryptionKeyRefProps")]
    public interface IEncryptionKeyRefProps
    {
        /// <summary>The ARN of the external KMS key.</summary>
        [JsiiProperty("keyArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.kms.KeyArn\"}")]
        KeyArn KeyArn
        {
            get;
            set;
        }
    }
}