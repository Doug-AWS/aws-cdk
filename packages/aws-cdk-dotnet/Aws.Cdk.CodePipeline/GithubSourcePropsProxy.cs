using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <summary>Construction properties of the {@link GitHubSource GitHub source action}</summary>
    [JsiiInterfaceProxy("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.GithubSourceProps")]
    public class GithubSourcePropsProxy : DeputyBase, IGithubSourceProps
    {
        private GithubSourcePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The name of the source's output artifact. Output artifacts are used by CodePipeline as
        /// inputs into other actions.
        /// </summary>
        [JsiiProperty("artifactName", "{\"primitive\":\"string\"}")]
        public virtual string ArtifactName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The GitHub account/user that owns the repo.</summary>
        [JsiiProperty("owner", "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The name of the repo, without the username.</summary>
        [JsiiProperty("repo", "{\"primitive\":\"string\"}")]
        public virtual string Repo
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The branch to use.</summary>
        /// <remarks>default: "master"</remarks>
        [JsiiProperty("branch", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Branch
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// A GitHub OAuth token to use for authentication.
        /// 
        /// It is recommended to use a `SecretParameter` to obtain the token from the SSM
        /// Parameter Store:
        /// 
        ///      const oauth = new SecretParameter(this, 'GitHubOAuthToken', { ssmParameter: 'my-github-token });
        ///      new GitHubSource(stage, 'GH' { oauthToken: oauth });
        /// </summary>
        [JsiiProperty("oauthToken", "{\"fqn\":\"jsii$_aws_cdk_core$.Secret\"}")]
        public virtual Secret OauthToken
        {
            get => GetProperty<Secret>();
            set => SetProperty(value);
        }

        /// <summary>Whether or not AWS CodePipeline should poll for source changes</summary>
        /// <remarks>default: true</remarks>
        [JsiiProperty("pollForSourceChanges", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? PollForSourceChanges
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }
    }
}