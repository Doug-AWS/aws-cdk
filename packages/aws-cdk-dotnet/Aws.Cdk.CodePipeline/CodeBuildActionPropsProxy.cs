using Aws.Cdk.CodeBuild;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <summary>Construction properties of the {@link CodeBuildAction CodeBuild action}</summary>
    [JsiiInterfaceProxy("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.CodeBuildActionProps")]
    public class CodeBuildActionPropsProxy : DeputyBase, ICodeBuildActionProps
    {
        private CodeBuildActionPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The source to use as input for this build</summary>
        [JsiiProperty("inputArtifact", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\"}")]
        public virtual Artifact InputArtifact
        {
            get => GetProperty<Artifact>();
            set => SetProperty(value);
        }

        /// <summary>The name of the build's output artifact</summary>
        [JsiiProperty("artifactName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string ArtifactName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The build project</summary>
        [JsiiProperty("project", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildProjectRef\"}")]
        public virtual BuildProjectRef Project
        {
            get => GetProperty<BuildProjectRef>();
            set => SetProperty(value);
        }
    }
}