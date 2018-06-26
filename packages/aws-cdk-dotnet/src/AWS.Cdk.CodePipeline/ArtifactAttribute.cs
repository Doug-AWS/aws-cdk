using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    /// <remarks>link: https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/continuous-delivery-codepipeline-parameter-override-functions.html </remarks>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.ArtifactAttribute", "[{\"name\":\"artifact\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\"}},{\"name\":\"attributeName\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ArtifactAttribute : Token
    {
        public ArtifactAttribute(Artifact artifact, string attributeName): base(new DeputyProps(new object[]{artifact, attributeName}))
        {
        }

        protected ArtifactAttribute(ByRefValue reference): base(reference)
        {
        }

        protected ArtifactAttribute(DeputyProps props): base(props)
        {
        }
    }
}