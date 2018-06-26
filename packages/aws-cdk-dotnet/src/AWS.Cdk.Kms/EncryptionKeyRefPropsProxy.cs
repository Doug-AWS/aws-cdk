using AWS.Cdk.Resources.kms;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Kms
{
    [JsiiInterfaceProxy("@aws-cdk/kms", "jsii$_aws_cdk_kms$.EncryptionKeyRefProps")]
    public class EncryptionKeyRefPropsProxy : DeputyBase, IEncryptionKeyRefProps
    {
        private EncryptionKeyRefPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The ARN of the external KMS key.</summary>
        [JsiiProperty("keyArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.kms.KeyArn\"}")]
        public virtual KeyArn KeyArn
        {
            get => GetProperty<KeyArn>();
            set => SetProperty(value);
        }
    }
}