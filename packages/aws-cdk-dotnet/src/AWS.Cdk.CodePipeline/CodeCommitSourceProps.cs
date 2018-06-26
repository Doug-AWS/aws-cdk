using AWS.Cdk.CodeCommit;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    /// <summary>Construction properties of the {@link CodeCommitSource CodeCommit source action}</summary>
    public class CodeCommitSourceProps : DeputyBase, ICodeCommitSourceProps
    {
        /// <summary>
        /// The name of the source's output artifact. Output artifacts are used by CodePipeline as
        /// inputs into other actions.
        /// </summary>
        [JsiiProperty("artifactName", "{\"primitive\":\"string\"}", true)]
        public string ArtifactName
        {
            get;
            set;
        }

        /// <summary>The CodeCommit repository.</summary>
        [JsiiProperty("repository", "{\"fqn\":\"jsii$_aws_cdk_codecommit$.RepositoryRef\"}", true)]
        public RepositoryRef Repository
        {
            get;
            set;
        }

        /// <remarks>default: 'master'</remarks>
        [JsiiProperty("branch", "{\"primitive\":\"string\",\"optional\":true}", true)]
        public string Branch
        {
            get;
            set;
        }

        /// <summary>Whether or not AWS CodePipeline should poll for source changes</summary>
        /// <remarks>default: true</remarks>
        [JsiiProperty("pollForSourceChanges", "{\"primitive\":\"boolean\",\"optional\":true}", true)]
        public bool? PollForSourceChanges
        {
            get;
            set;
        }
    }
}