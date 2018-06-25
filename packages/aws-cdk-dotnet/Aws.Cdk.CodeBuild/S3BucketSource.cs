using Aws.Cdk.Resources.codebuild.ProjectResource;
using Aws.Cdk.S3;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    /// <summary>S3 bucket definition for a CodeBuild project.</summary>
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.S3BucketSource", "[{\"name\":\"bucket\",\"type\":{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\"}},{\"name\":\"path\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketSource : BuildSource
    {
        public S3BucketSource(BucketRef bucket, string path): base(new DeputyProps(new object[]{bucket, path}))
        {
        }

        protected S3BucketSource(ByRefValue reference): base(reference)
        {
        }

        protected S3BucketSource(DeputyProps props): base(props)
        {
        }

        [JsiiMethod("toSourceJSON", "{\"fqn\":\"jsii$_aws_cdk_resources$.codebuild.ProjectResource.SourceProperty\"}", "[]")]
        public override ISourceProperty ToSourceJSON()
        {
            return InvokeMethod<ISourceProperty>(new object[]{});
        }

        /// <summary>
        /// Called by the project when the source is added so that the source can perform
        /// binding operations on the source. For example, it can grant permissions to the
        /// code build project to read from the S3 bucket.
        /// </summary>
        [JsiiMethod("bind", null, "[{\"name\":\"project\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildProject\"}}]")]
        public override void Bind(BuildProject project)
        {
            InvokeVoidMethod(new object[]{project});
        }
    }
}