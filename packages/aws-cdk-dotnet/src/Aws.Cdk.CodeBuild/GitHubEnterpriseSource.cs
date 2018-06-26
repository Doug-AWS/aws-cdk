using Aws.Cdk.Resources.codebuild.ProjectResource;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    /// <summary>GitHub Enterprice Source definition for a CodeBuild project</summary>
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.GitHubEnterpriseSource", "[{\"name\":\"cloneUrl\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GitHubEnterpriseSource : BuildSource
    {
        public GitHubEnterpriseSource(string cloneUrl): base(new DeputyProps(new object[]{cloneUrl}))
        {
        }

        protected GitHubEnterpriseSource(ByRefValue reference): base(reference)
        {
        }

        protected GitHubEnterpriseSource(DeputyProps props): base(props)
        {
        }

        [JsiiMethod("toSourceJSON", "{\"fqn\":\"jsii$_aws_cdk_resources$.codebuild.ProjectResource.SourceProperty\"}", "[]")]
        public override ISourceProperty ToSourceJSON()
        {
            return InvokeMethod<ISourceProperty>(new object[]{});
        }
    }
}