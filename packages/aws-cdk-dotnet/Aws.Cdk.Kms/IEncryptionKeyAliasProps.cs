using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Kms
{
    [JsiiInterface("@aws-cdk/kms", "jsii$_aws_cdk_kms$.EncryptionKeyAliasProps")]
    public interface IEncryptionKeyAliasProps
    {
        /// <summary>
        /// The name of the alias. The name must start with alias followed by a
        /// forward slash, such as alias/. You can't specify aliases that begin with
        /// alias/AWS. These aliases are reserved.
        /// </summary>
        [JsiiProperty("alias", "{\"primitive\":\"string\"}")]
        string Alias
        {
            get;
            set;
        }

        /// <summary>
        /// The ID of the key for which you are creating the alias. Specify the key's
        /// globally unique identifier or Amazon Resource Name (ARN). You can't
        /// specify another alias.
        /// </summary>
        [JsiiProperty("key", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRef\"}")]
        EncryptionKeyRef Key
        {
            get;
            set;
        }
    }
}