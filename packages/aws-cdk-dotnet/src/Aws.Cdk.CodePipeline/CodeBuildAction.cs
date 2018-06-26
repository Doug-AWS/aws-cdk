using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <summary>Build action that uses AWS CodeBuild</summary>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.CodeBuildAction", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Stage\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.CodeBuildActionProps\"}}]")]
    public class CodeBuildAction : BuildAction
    {
        public CodeBuildAction(Stage parent, string name, ICodeBuildActionProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected CodeBuildAction(ByRefValue reference): base(reference)
        {
        }

        protected CodeBuildAction(DeputyProps props): base(props)
        {
        }
    }
}