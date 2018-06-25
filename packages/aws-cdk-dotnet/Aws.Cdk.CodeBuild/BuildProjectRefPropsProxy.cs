using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    /// <summary>Properties of a reference to a CodeBuild Project.</summary>
    /// <remarks>see: BuildProjectRef.export</remarks>
    [JsiiInterfaceProxy("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.BuildProjectRefProps")]
    public class BuildProjectRefPropsProxy : DeputyBase, IBuildProjectRefProps
    {
        private BuildProjectRefPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The human-readable name of the CodeBuild Project we're referencing.
        /// The Project must be in the same account and region as the root Stack.
        /// </summary>
        [JsiiProperty("projectName", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.ProjectName\"}")]
        public virtual ProjectName ProjectName
        {
            get => GetProperty<ProjectName>();
            set => SetProperty(value);
        }
    }
}