using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    /// <summary>
    /// Low level class for source actions.
    /// It is recommended that concrete types are used instead, such as {@link AmazonS3Source} or
    /// {@link CodeCommitSource}.
    /// </summary>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.Source", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Stage\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.SourceProps\"}}]")]
    public abstract class Source : Action
    {
        protected Source(Stage parent, string name, ISourceProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Source(ByRefValue reference): base(reference)
        {
        }

        protected Source(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("artifact", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\"}")]
        public virtual Artifact Artifact
        {
            get => GetProperty<Artifact>();
        }
    }
}