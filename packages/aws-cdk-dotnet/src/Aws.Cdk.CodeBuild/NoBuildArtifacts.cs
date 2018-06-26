using Aws.Cdk.Resources.codebuild.ProjectResource;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.NoBuildArtifacts", "[]")]
    public class NoBuildArtifacts : BuildArtifacts
    {
        public NoBuildArtifacts(): base(new DeputyProps(new object[]{}))
        {
        }

        protected NoBuildArtifacts(ByRefValue reference): base(reference)
        {
        }

        protected NoBuildArtifacts(DeputyProps props): base(props)
        {
        }

        [JsiiMethod("toArtifactsJSON", "{\"fqn\":\"jsii$_aws_cdk_resources$.codebuild.ProjectResource.ArtifactsProperty\"}", "[]")]
        public override IArtifactsProperty ToArtifactsJSON()
        {
            return InvokeMethod<IArtifactsProperty>(new object[]{});
        }
    }
}