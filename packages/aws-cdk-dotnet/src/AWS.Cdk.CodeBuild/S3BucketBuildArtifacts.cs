using AWS.Cdk.Resources.codebuild.ProjectResource;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodeBuild
{
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.S3BucketBuildArtifacts", "[{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codebuild$.S3BucketBuildArtifactsProps\"}}]")]
    public class S3BucketBuildArtifacts : BuildArtifacts
    {
        public S3BucketBuildArtifacts(IS3BucketBuildArtifactsProps props): base(new DeputyProps(new object[]{props}))
        {
        }

        protected S3BucketBuildArtifacts(ByRefValue reference): base(reference)
        {
        }

        protected S3BucketBuildArtifacts(DeputyProps props): base(props)
        {
        }

        [JsiiMethod("bind", null, "[{\"name\":\"project\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildProject\"}}]")]
        public override void Bind(BuildProject project)
        {
            InvokeVoidMethod(new object[]{project});
        }

        [JsiiMethod("toArtifactsJSON", "{\"fqn\":\"jsii$_aws_cdk_resources$.codebuild.ProjectResource.ArtifactsProperty\"}", "[]")]
        public override IArtifactsProperty ToArtifactsJSON()
        {
            return InvokeMethod<IArtifactsProperty>(new object[]{});
        }
    }
}