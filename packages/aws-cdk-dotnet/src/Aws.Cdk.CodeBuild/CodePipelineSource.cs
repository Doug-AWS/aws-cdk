using Aws.Cdk.Resources.codebuild.ProjectResource;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    /// <summary>CodePipeline Source definition for a CodeBuild project</summary>
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.CodePipelineSource", "[]")]
    public class CodePipelineSource : BuildSource
    {
        public CodePipelineSource(): base(new DeputyProps(new object[]{}))
        {
        }

        protected CodePipelineSource(ByRefValue reference): base(reference)
        {
        }

        protected CodePipelineSource(DeputyProps props): base(props)
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
        [JsiiMethod("bind", null, "[{\"name\":\"_project\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildProject\"}}]")]
        public override void Bind(BuildProject _project)
        {
            InvokeVoidMethod(new object[]{_project});
        }
    }
}