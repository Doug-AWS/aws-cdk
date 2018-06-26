using AWS.Cdk.CodeBuild;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    /// <summary>Construction properties of the {@link CodeBuildAction CodeBuild action}</summary>
    public class CodeBuildActionProps : DeputyBase, ICodeBuildActionProps
    {
        /// <summary>The source to use as input for this build</summary>
        [JsiiProperty("inputArtifact", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\"}", true)]
        public Artifact InputArtifact
        {
            get;
            set;
        }

        /// <summary>The name of the build's output artifact</summary>
        [JsiiProperty("artifactName", "{\"primitive\":\"string\",\"optional\":true}", true)]
        public string ArtifactName
        {
            get;
            set;
        }

        /// <summary>The build project</summary>
        [JsiiProperty("project", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildProjectRef\"}", true)]
        public BuildProjectRef Project
        {
            get;
            set;
        }
    }
}