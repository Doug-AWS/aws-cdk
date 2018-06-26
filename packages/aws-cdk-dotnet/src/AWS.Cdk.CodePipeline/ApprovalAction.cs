using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    /// <summary>Manual approval action</summary>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.ApprovalAction", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Stage\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApprovalAction : Action
    {
        public ApprovalAction(Stage parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected ApprovalAction(ByRefValue reference): base(reference)
        {
        }

        protected ApprovalAction(DeputyProps props): base(props)
        {
        }
    }
}