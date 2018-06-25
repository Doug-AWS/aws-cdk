using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Kms
{
    [JsiiInterfaceProxy("@aws-cdk/kms", "jsii$_aws_cdk_kms$.EncryptionKeyAliasProps")]
    public class EncryptionKeyAliasPropsProxy : DeputyBase, IEncryptionKeyAliasProps
    {
        private EncryptionKeyAliasPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The name of the alias. The name must start with alias followed by a
        /// forward slash, such as alias/. You can't specify aliases that begin with
        /// alias/AWS. These aliases are reserved.
        /// </summary>
        [JsiiProperty("alias", "{\"primitive\":\"string\"}")]
        public virtual string Alias
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The ID of the key for which you are creating the alias. Specify the key's
        /// globally unique identifier or Amazon Resource Name (ARN). You can't
        /// specify another alias.
        /// </summary>
        [JsiiProperty("key", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRef\"}")]
        public virtual EncryptionKeyRef Key
        {
            get => GetProperty<EncryptionKeyRef>();
            set => SetProperty(value);
        }
    }
}