using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <remarks>link: https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/continuous-delivery-codepipeline-parameter-override-functions.html </remarks>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.ArtifactGetParam", "[{\"name\":\"artifact\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\"}},{\"name\":\"jsonFile\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"keyName\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ArtifactGetParam : Token
    {
        public ArtifactGetParam(Artifact artifact, string jsonFile, string keyName): base(new DeputyProps(new object[]{artifact, jsonFile, keyName}))
        {
        }

        protected ArtifactGetParam(ByRefValue reference): base(reference)
        {
        }

        protected ArtifactGetParam(DeputyProps props): base(props)
        {
        }
    }
}