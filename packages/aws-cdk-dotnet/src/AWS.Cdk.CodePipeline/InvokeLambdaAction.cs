using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    /// <remarks>link: https://docs.aws.amazon.com/codepipeline/latest/userguide/actions-invoke-lambda-function.html </remarks>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.InvokeLambdaAction", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Stage\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.InvokeLambdaProps\"}}]")]
    public class InvokeLambdaAction : Action
    {
        public InvokeLambdaAction(Stage parent, string name, IInvokeLambdaProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected InvokeLambdaAction(ByRefValue reference): base(reference)
        {
        }

        protected InvokeLambdaAction(DeputyProps props): base(props)
        {
        }

        /// <summary>Add an input artifact</summary>
        [JsiiMethod("addInputArtifact", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.InvokeLambdaAction\"}", "[{\"name\":\"artifact\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\"}}]")]
        public override InvokeLambdaAction AddInputArtifact(Artifact artifact)
        {
            return InvokeMethod<InvokeLambdaAction>(new object[]{artifact});
        }
    }
}