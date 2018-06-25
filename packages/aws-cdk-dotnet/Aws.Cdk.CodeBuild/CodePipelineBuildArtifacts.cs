using Aws.Cdk.Resources.codebuild.ProjectResource;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.CodePipelineBuildArtifacts", "[]")]
    public class CodePipelineBuildArtifacts : BuildArtifacts
    {
        public CodePipelineBuildArtifacts(): base(new DeputyProps(new object[]{}))
        {
        }

        protected CodePipelineBuildArtifacts(ByRefValue reference): base(reference)
        {
        }

        protected CodePipelineBuildArtifacts(DeputyProps props): base(props)
        {
        }

        [JsiiMethod("toArtifactsJSON", "{\"fqn\":\"jsii$_aws_cdk_resources$.codebuild.ProjectResource.ArtifactsProperty\"}", "[]")]
        public override IArtifactsProperty ToArtifactsJSON()
        {
            return InvokeMethod<IArtifactsProperty>(new object[]{});
        }
    }
}