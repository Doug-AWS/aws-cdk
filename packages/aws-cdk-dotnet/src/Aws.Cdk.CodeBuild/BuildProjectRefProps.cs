using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    /// <summary>Properties of a reference to a CodeBuild Project.</summary>
    /// <remarks>see: BuildProjectRef.export</remarks>
    public class BuildProjectRefProps : DeputyBase, IBuildProjectRefProps
    {
        /// <summary>
        /// The human-readable name of the CodeBuild Project we're referencing.
        /// The Project must be in the same account and region as the root Stack.
        /// </summary>
        [JsiiProperty("projectName", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.ProjectName\"}", true)]
        public ProjectName ProjectName
        {
            get;
            set;
        }
    }
}