using Aws.Cdk;
using Aws.Cdk.Resources.kms;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Kms
{
    /// <summary>Definews a KMS key.</summary>
    [JsiiClass("@aws-cdk/kms", "jsii$_aws_cdk_kms$.EncryptionKey", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyProps\",\"optional\":true}}]")]
    public class EncryptionKey : EncryptionKeyRef
    {
        public EncryptionKey(Construct parent, string name, IEncryptionKeyProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected EncryptionKey(ByRefValue reference): base(reference)
        {
        }

        protected EncryptionKey(DeputyProps props): base(props)
        {
        }

        /// <summary>The ARN of the key.</summary>
        [JsiiProperty("keyArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.kms.KeyArn\"}")]
        public override KeyArn KeyArn
        {
            get => GetProperty<KeyArn>();
        }

        /// <summary>
        /// Optional policy document that represents the resource policy of this key.
        /// 
        /// If specified, addToResourcePolicy can be used to edit this policy.
        /// Otherwise this method will no-op.
        /// </summary>
        [JsiiProperty("policy", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyDocument\",\"optional\":true}")]
        protected override PolicyDocument Policy
        {
            get => GetProperty<PolicyDocument>();
        }
    }
}