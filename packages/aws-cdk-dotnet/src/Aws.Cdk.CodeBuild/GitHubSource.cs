using Aws.Cdk.Resources.codebuild.ProjectResource;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    /// <summary>GitHub Source definition for a CodeBuild project</summary>
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.GitHubSource", "[{\"name\":\"httpscloneUrl\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"oauthToken\",\"type\":{\"primitive\":\"any\"}}]")]
    public class GitHubSource : BuildSource
    {
        public GitHubSource(string httpscloneUrl, object oauthToken): base(new DeputyProps(new object[]{httpscloneUrl, oauthToken}))
        {
        }

        protected GitHubSource(ByRefValue reference): base(reference)
        {
        }

        protected GitHubSource(DeputyProps props): base(props)
        {
        }

        [JsiiMethod("toSourceJSON", "{\"fqn\":\"jsii$_aws_cdk_resources$.codebuild.ProjectResource.SourceProperty\"}", "[]")]
        public override ISourceProperty ToSourceJSON()
        {
            return InvokeMethod<ISourceProperty>(new object[]{});
        }
    }
}