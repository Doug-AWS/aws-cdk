using AWS.Cdk.Resources.codebuild.ProjectResource;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodeBuild
{
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.BuildArtifacts", "[]")]
    public abstract class BuildArtifacts : DeputyBase
    {
        protected BuildArtifacts(): base(new DeputyProps(new object[]{}))
        {
        }

        protected BuildArtifacts(ByRefValue reference): base(reference)
        {
        }

        protected BuildArtifacts(DeputyProps props): base(props)
        {
        }

        [JsiiMethod("toArtifactsJSON", "{\"fqn\":\"jsii$_aws_cdk_resources$.codebuild.ProjectResource.ArtifactsProperty\"}", "[]")]
        public abstract IArtifactsProperty ToArtifactsJSON();
        [JsiiMethod("bind", null, "[{\"name\":\"_project\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildProject\"}}]")]
        public virtual void Bind(BuildProject _project)
        {
            InvokeVoidMethod(new object[]{_project});
        }
    }
}