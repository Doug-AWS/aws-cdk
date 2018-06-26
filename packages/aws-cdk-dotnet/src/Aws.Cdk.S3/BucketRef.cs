using Aws.Cdk;
using Aws.Cdk.Iam;
using Aws.Cdk.Kms;
using Aws.Cdk.Resources.s3;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.S3
{
    /// <summary>
    /// Represents an S3 Bucket.
    /// 
    /// Buckets can be either defined within this stack:
    /// 
    ///      new Bucket(this, 'MyBucket', { props });
    /// 
    /// Or imported from an existing bucket:
    /// 
    ///      BucketRef.import(this, 'MyImportedBucket', { bucketArn: ... });
    /// 
    /// You can also export a bucket and import it into another stack:
    /// 
    ///      const ref = myBucket.export();
    ///      BucketRef.import(this, 'MyImportedBucket', ref);
    /// </summary>
    [JsiiClass("@aws-cdk/s3", "jsii$_aws_cdk_s3$.BucketRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class BucketRef : Construct
    {
        protected BucketRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected BucketRef(ByRefValue reference): base(reference)
        {
        }

        protected BucketRef(DeputyProps props): base(props)
        {
        }

        /// <summary>The ARN of the bucket.</summary>
        [JsiiProperty("bucketArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.s3.BucketArn\"}")]
        public virtual BucketArn BucketArn
        {
            get => GetProperty<BucketArn>();
        }

        /// <summary>The name of the bucket.</summary>
        [JsiiProperty("bucketName", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketName\"}")]
        public virtual BucketName BucketName
        {
            get => GetProperty<BucketName>();
        }

        /// <summary>Optional KMS encryption key associated with this bucket.</summary>
        [JsiiProperty("encryptionKey", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRef\",\"optional\":true}")]
        public virtual EncryptionKeyRef EncryptionKey
        {
            get => GetProperty<EncryptionKeyRef>();
        }

        /// <summary>
        /// The resource policy assoicated with this bucket.
        /// 
        /// If `autoCreatePolicy` is true, a `BucketPolicy` will be created upon the
        /// first call to addToResourcePolicy(s).
        /// </summary>
        [JsiiProperty("policy", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketPolicy\",\"optional\":true}")]
        protected virtual BucketPolicy Policy
        {
            get => GetProperty<BucketPolicy>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Indicates if a bucket resource policy should automatically created upon
        /// the first call to `addToResourcePolicy`.
        /// </summary>
        [JsiiProperty("autoCreatePolicy", "{\"primitive\":\"boolean\"}")]
        protected virtual bool AutoCreatePolicy
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }

        /// <summary>Creates a Bucket construct that represents an external bucket.</summary>
        /// <param name = "parent">The parent creating construct (usually `this`).</param>
        /// <param name = "name">The construct's name.</param>
        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRefProps\"}}]")]
        public virtual BucketRef Import(Construct parent, string name, IBucketRefProps props)
        {
            return InvokeMethod<BucketRef>(new object[]{parent, name, props});
        }

        /// <summary>Exports this bucket from the stack.</summary>
        [JsiiMethod("export", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRefProps\"}", "[]")]
        public virtual IBucketRefProps Export()
        {
            return InvokeMethod<IBucketRefProps>(new object[]{});
        }

        /// <summary>
        /// Adds a statement to the resource policy for a principal (i.e.
        /// account/role/service) to perform actions on this bucket and/or it's
        /// contents. Use `bucketArn` and `arnForObjects(keys)` to obtain ARNs for
        /// this bucket or objects.
        /// </summary>
        [JsiiMethod("addToResourcePolicy", null, "[{\"name\":\"permission\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddToResourcePolicy(PolicyStatement permission)
        {
            InvokeVoidMethod(new object[]{permission});
        }

        /// <summary>
        /// Returns an ARN that represents all objects within the bucket that match
        /// the key pattern specified. To represent all keys, specify ``"*"``.
        /// 
        /// If you specify multiple components for keyPattern, they will be concatenated::
        /// 
        ///      arnForObjects('home/', team, '/', user, '/*')
        /// </summary>
        [JsiiMethod("arnForObjects", "{\"fqn\":\"jsii$_aws_cdk_core$.Arn\"}", "[{\"name\":\"keyPattern\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual Arn ArnForObjects(object keyPattern)
        {
            return InvokeMethod<Arn>(new object[]{keyPattern});
        }

        /// <summary>
        /// Temporary API for granting read permissions for this bucket and it's
        /// contents to an IAM principal (Role/Group/User).
        /// 
        /// If an encryption key is used, permission to ues the key to decrypt the
        /// contents of the bucket will also be granted.
        /// </summary>
        [JsiiMethod("grantRead", null, "[{\"name\":\"identity\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.IIdentityResource\",\"optional\":true}},{\"name\":\"objectsKeyPattern\",\"type\":{\"primitive\":\"string\",\"optional\":true}}]")]
        public virtual void GrantRead(IIIdentityResource identity, string objectsKeyPattern)
        {
            InvokeVoidMethod(new object[]{identity, objectsKeyPattern});
        }

        /// <summary>
        /// Grants read/write permissions for this bucket and it's contents to an IAM
        /// principal (Role/Group/User).
        /// 
        /// If an encryption key is used, permission to use the key for
        /// encrypt/decrypt will also be granted.
        /// </summary>
        [JsiiMethod("grantReadWrite", null, "[{\"name\":\"identity\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.IIdentityResource\",\"optional\":true}},{\"name\":\"objectsKeyPattern\",\"type\":{\"primitive\":\"string\",\"optional\":true}}]")]
        public virtual void GrantReadWrite(IIIdentityResource identity, string objectsKeyPattern)
        {
            InvokeVoidMethod(new object[]{identity, objectsKeyPattern});
        }
    }
}