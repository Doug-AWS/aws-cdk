using Aws.Cdk.CodeBuild;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <summary>Construction properties of the {@link CodeBuildAction CodeBuild action}</summary>
    [JsiiInterface("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.CodeBuildActionProps")]
    public interface ICodeBuildActionProps
    {
        /// <summary>The source to use as input for this build</summary>
        [JsiiProperty("inputArtifact", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\"}")]
        Artifact InputArtifact
        {
            get;
            set;
        }

        /// <summary>The name of the build's output artifact</summary>
        [JsiiProperty("artifactName", "{\"primitive\":\"string\",\"optional\":true}")]
        string ArtifactName
        {
            get;
            set;
        }

        /// <summary>The build project</summary>
        [JsiiProperty("project", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildProjectRef\"}")]
        BuildProjectRef Project
        {
            get;
            set;
        }
    }
}