using Aws.Cdk.CodeCommit;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <summary>Construction properties of the {@link CodeCommitSource CodeCommit source action}</summary>
    [JsiiInterfaceProxy("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.CodeCommitSourceProps")]
    public class CodeCommitSourcePropsProxy : DeputyBase, ICodeCommitSourceProps
    {
        private CodeCommitSourcePropsProxy(ByRefValue reference): base(reference)
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

        /// <summary>The CodeCommit repository.</summary>
        [JsiiProperty("repository", "{\"fqn\":\"jsii$_aws_cdk_codecommit$.RepositoryRef\"}")]
        public virtual RepositoryRef Repository
        {
            get => GetProperty<RepositoryRef>();
            set => SetProperty(value);
        }

        /// <remarks>default: 'master'</remarks>
        [JsiiProperty("branch", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Branch
        {
            get => GetProperty<string>();
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