using Aws.Cdk;
using Aws.Cdk.Resources.kms;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Kms
{
    [JsiiClass("@aws-cdk/kms", "jsii$_aws_cdk_kms$.EncryptionKeyRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class EncryptionKeyRef : Construct
    {
        protected EncryptionKeyRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected EncryptionKeyRef(ByRefValue reference): base(reference)
        {
        }

        protected EncryptionKeyRef(DeputyProps props): base(props)
        {
        }

        /// <summary>The ARN of the key.</summary>
        [JsiiProperty("keyArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.kms.KeyArn\"}")]
        public virtual KeyArn KeyArn
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
        protected virtual PolicyDocument Policy
        {
            get => GetProperty<PolicyDocument>();
        }

        /// <summary>
        /// Defines an imported encryption key.
        /// 
        /// `ref` can be obtained either via a call to `key.export()` or using
        /// literals.
        /// 
        /// For example:
        /// 
        ///      const keyRefProps = key.export();
        ///      const keyRef1 = EncryptionKeyRef.import(this, 'MyImportedKey1', keyRefProps);
        ///      const keyRef2 = EncryptionKeyRef.import(this, 'MyImportedKey2', {
        ///          keyArn: new KeyArn('arn:aws:kms:...')
        ///      });
        /// </summary>
        /// <param name = "parent">The parent construct.</param>
        /// <param name = "name">The name of the construct.</param>
        /// <param name = "props">The key reference.</param>
        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRefProps\"}}]")]
        public virtual EncryptionKeyRef Import(Construct parent, string name, IEncryptionKeyRefProps props)
        {
            return InvokeMethod<EncryptionKeyRef>(new object[]{parent, name, props});
        }

        /// <summary>Defines a new alias for the key.</summary>
        [JsiiMethod("addAlias", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyAlias\"}", "[{\"name\":\"alias\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual EncryptionKeyAlias AddAlias(string alias)
        {
            return InvokeMethod<EncryptionKeyAlias>(new object[]{alias});
        }

        /// <summary>Adds a statement to the KMS key resource policy.</summary>
        [JsiiMethod("addToResourcePolicy", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddToResourcePolicy(PolicyStatement statement)
        {
            InvokeVoidMethod(new object[]{statement});
        }

        /// <summary>Exports this key from the current stack.</summary>
        /// <returns>a key ref which can be used in a call to `EncryptionKey.import(ref)`.</returns>
        [JsiiMethod("export", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRefProps\"}", "[]")]
        public virtual IEncryptionKeyRefProps Export()
        {
            return InvokeMethod<IEncryptionKeyRefProps>(new object[]{});
        }
    }
}