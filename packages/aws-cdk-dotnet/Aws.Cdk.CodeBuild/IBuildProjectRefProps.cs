using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    /// <summary>Properties of a reference to a CodeBuild Project.</summary>
    /// <remarks>see: BuildProjectRef.export</remarks>
    [JsiiInterface("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.BuildProjectRefProps")]
    public interface IBuildProjectRefProps
    {
        /// <summary>
        /// The human-readable name of the CodeBuild Project we're referencing.
        /// The Project must be in the same account and region as the root Stack.
        /// </summary>
        [JsiiProperty("projectName", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.ProjectName\"}")]
        ProjectName ProjectName
        {
            get;
            set;
        }
    }
}