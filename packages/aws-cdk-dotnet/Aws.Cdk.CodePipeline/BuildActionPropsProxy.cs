using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <summary>Construction properties of the low level {@link BuildAction build action}</summary>
    [JsiiInterfaceProxy("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.BuildActionProps")]
    public class BuildActionPropsProxy : DeputyBase, IBuildActionProps
    {
        private BuildActionPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The source to use as input for this build</summary>
        [JsiiProperty("inputArtifact", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\"}")]
        public virtual Artifact InputArtifact
        {
            get => GetProperty<Artifact>();
            set => SetProperty(value);
        }

        /// <summary>The service provider that the action calls. For example, a valid provider for Source actions is CodeBuild.</summary>
        [JsiiProperty("provider", "{\"primitive\":\"string\"}")]
        public virtual string Provider
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The name of the build's output artifact</summary>
        [JsiiProperty("artifactName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string ArtifactName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The action's configuration. These are key-value pairs that specify input values for an action.
        /// For more information, see the AWS CodePipeline User Guide.
        /// 
        /// http://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#action-requirements
        /// </summary>
        [JsiiProperty("configuration", "{\"primitive\":\"any\",\"optional\":true}")]
        public virtual object Configuration
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }
    }
}