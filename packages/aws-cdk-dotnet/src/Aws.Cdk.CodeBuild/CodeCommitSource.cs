using Aws.Cdk.CodeCommit;
using Aws.Cdk.Resources.codebuild.ProjectResource;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    /// <summary>CodeCommit Source definition for a CodeBuild project</summary>
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.CodeCommitSource", "[{\"name\":\"repo\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codecommit$.Repository\"}}]")]
    public class CodeCommitSource : BuildSource
    {
        public CodeCommitSource(Repository repo): base(new DeputyProps(new object[]{repo}))
        {
        }

        protected CodeCommitSource(ByRefValue reference): base(reference)
        {
        }

        protected CodeCommitSource(DeputyProps props): base(props)
        {
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

        [JsiiMethod("toSourceJSON", "{\"fqn\":\"jsii$_aws_cdk_resources$.codebuild.ProjectResource.SourceProperty\"}", "[]")]
        public override ISourceProperty ToSourceJSON()
        {
            return InvokeMethod<ISourceProperty>(new object[]{});
        }
    }
}