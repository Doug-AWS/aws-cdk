using AWS.Cdk.S3;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    /// <summary>Construction properties of the {@link AmazonS3Source S3 source action}</summary>
    [JsiiInterfaceProxy("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.AmazonS3SourceProps")]
    public class AmazonS3SourcePropsProxy : DeputyBase, IAmazonS3SourceProps
    {
        private AmazonS3SourcePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The name of the source's output artifact. Output artifacts are used by CodePipeline as
        /// inputs into other actions.
        /// </summary>
        [JsiiProperty("artifactName", "{\"primitive\":\"string\"}")]
        public virtual string ArtifactName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The Amazon S3 bucket that stores the source code</summary>
        [JsiiProperty("bucket", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\"}")]
        public virtual BucketRef Bucket
        {
            get => GetProperty<BucketRef>();
            set => SetProperty(value);
        }

        /// <summary>The key within the S3 bucket that stores the source code</summary>
        [JsiiProperty("bucketKey", "{\"primitive\":\"string\"}")]
        public virtual string BucketKey
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Whether or not AWS CodePipeline should poll for source changes</summary>
        /// <remarks>default: true</remarks>
        [JsiiProperty("pollForSourceChanges", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? PollForSourceChanges
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }
    }
}