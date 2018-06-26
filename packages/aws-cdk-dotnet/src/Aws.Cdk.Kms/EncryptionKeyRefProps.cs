using Aws.Cdk.Resources.kms;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Kms
{
    public class EncryptionKeyRefProps : DeputyBase, IEncryptionKeyRefProps
    {
        /// <summary>The ARN of the external KMS key.</summary>
        [JsiiProperty("keyArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.kms.KeyArn\"}", true)]
        public KeyArn KeyArn
        {
            get;
            set;
        }
    }
}