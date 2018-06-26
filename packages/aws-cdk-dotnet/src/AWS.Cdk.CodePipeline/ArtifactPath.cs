using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    /// <summary>
    /// A specific file within an output artifact.
    /// 
    /// The most common use case for this is specifying the template file
    /// for a CloudFormation action.
    /// </summary>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.ArtifactPath", "[{\"name\":\"artifact\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\"}},{\"name\":\"fileName\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ArtifactPath : DeputyBase
    {
        public ArtifactPath(Artifact artifact, string fileName): base(new DeputyProps(new object[]{artifact, fileName}))
        {
        }

        protected ArtifactPath(ByRefValue reference): base(reference)
        {
        }

        protected ArtifactPath(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("artifact", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\"}")]
        public virtual Artifact Artifact
        {
            get => GetProperty<Artifact>();
        }

        [JsiiProperty("fileName", "{\"primitive\":\"string\"}")]
        public virtual string FileName
        {
            get => GetProperty<string>();
        }

        [JsiiProperty("location", "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetProperty<string>();
        }
    }
}