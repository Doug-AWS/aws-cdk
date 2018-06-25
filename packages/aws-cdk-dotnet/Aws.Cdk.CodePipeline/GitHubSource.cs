using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <summary>Source that is provided by a GitHub repository</summary>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.GitHubSource", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Stage\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.GithubSourceProps\"}}]")]
    public class GitHubSource : Source
    {
        public GitHubSource(Stage parent, string name, IGithubSourceProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected GitHubSource(ByRefValue reference): base(reference)
        {
        }

        protected GitHubSource(DeputyProps props): base(props)
        {
        }
    }
}