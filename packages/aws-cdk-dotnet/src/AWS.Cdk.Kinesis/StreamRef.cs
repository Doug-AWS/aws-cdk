using AWS.Cdk;
using AWS.Cdk.Iam;
using AWS.Cdk.Kms;
using AWS.Cdk.Resources.kinesis;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Kinesis
{
    /// <summary>
    /// Represents a Kinesis Stream.
    /// 
    /// Streams can be either defined within this stack:
    /// 
    ///      new Stream(this, 'MyStream', { props });
    /// 
    /// Or imported from an existing stream:
    /// 
    ///      StreamRef.import(this, 'MyImportedStream', { streamArn: ... });
    /// 
    /// You can also export a stream and import it into another stack:
    /// 
    ///      const ref = myStream.export();
    ///      StreamRef.import(this, 'MyImportedStream', ref);
    /// </summary>
    [JsiiClass("@aws-cdk/kinesis", "jsii$_aws_cdk_kinesis$.StreamRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class StreamRef : Construct
    {
        protected StreamRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected StreamRef(ByRefValue reference): base(reference)
        {
        }

        protected StreamRef(DeputyProps props): base(props)
        {
        }

        /// <summary>The ARN of the stream.</summary>
        [JsiiProperty("streamArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.kinesis.StreamArn\"}")]
        public virtual StreamArn StreamArn
        {
            get => GetProperty<StreamArn>();
        }

        /// <summary>Optional KMS encryption key associated with this stream.</summary>
        [JsiiProperty("encryptionKey", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRef\",\"optional\":true}")]
        public virtual EncryptionKeyRef EncryptionKey
        {
            get => GetProperty<EncryptionKeyRef>();
        }

        /// <summary>Creates a Stream construct that represents an external stream.</summary>
        /// <param name = "parent">The parent creating construct (usually `this`).</param>
        /// <param name = "name">The construct's name.</param>
        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_kinesis$.StreamRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_kinesis$.StreamRefProps\"}}]")]
        public virtual StreamRef Import(Construct parent, string name, IStreamRefProps props)
        {
            return InvokeMethod<StreamRef>(new object[]{parent, name, props});
        }

        /// <summary>Exports this stream from the stack.</summary>
        [JsiiMethod("export", "{\"fqn\":\"jsii$_aws_cdk_kinesis$.StreamRefProps\"}", "[]")]
        public virtual IStreamRefProps Export()
        {
            return InvokeMethod<IStreamRefProps>(new object[]{});
        }

        /// <summary>
        /// Grant write permissions for this stream and its contents to an IAM
        /// principal (Role/Group/User).
        /// 
        /// If an encryption key is used, permission to ues the key to decrypt the
        /// contents of the stream will also be granted.
        /// </summary>
        [JsiiMethod("grantRead", null, "[{\"name\":\"identity\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.IIdentityResource\",\"optional\":true}}]")]
        public virtual void GrantRead(IIIdentityResource identity)
        {
            InvokeVoidMethod(new object[]{identity});
        }

        /// <summary>
        /// Grant read permissions for this stream and its contents to an IAM
        /// principal (Role/Group/User).
        /// 
        /// If an encryption key is used, permission to ues the key to decrypt the
        /// contents of the stream will also be granted.
        /// </summary>
        [JsiiMethod("grantWrite", null, "[{\"name\":\"identity\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.IIdentityResource\",\"optional\":true}}]")]
        public virtual void GrantWrite(IIIdentityResource identity)
        {
            InvokeVoidMethod(new object[]{identity});
        }

        /// <summary>
        /// Grants read/write permissions for this stream and its contents to an IAM
        /// principal (Role/Group/User).
        /// 
        /// If an encryption key is used, permission to use the key for
        /// encrypt/decrypt will also be granted.
        /// </summary>
        [JsiiMethod("grantReadWrite", null, "[{\"name\":\"identity\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.IIdentityResource\",\"optional\":true}}]")]
        public virtual void GrantReadWrite(IIIdentityResource identity)
        {
            InvokeVoidMethod(new object[]{identity});
        }
    }
}