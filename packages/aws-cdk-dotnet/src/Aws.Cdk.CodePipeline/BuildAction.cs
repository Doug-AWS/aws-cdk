using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <summary>
    /// Low level class for build actions.
    /// It is recommended that concrete types are used instead, such as {@link CodeBuildAction}.
    /// </summary>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.BuildAction", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Stage\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.BuildActionProps\"}}]")]
    public abstract class BuildAction : Action
    {
        protected BuildAction(Stage parent, string name, IBuildActionProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected BuildAction(ByRefValue reference): base(reference)
        {
        }

        protected BuildAction(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("artifact", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\",\"optional\":true}")]
        public virtual Artifact Artifact
        {
            get => GetProperty<Artifact>();
        }
    }
}