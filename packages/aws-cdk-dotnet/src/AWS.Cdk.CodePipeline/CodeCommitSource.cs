using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    /// <summary>Source that is provided by an AWS CodeCommit repository</summary>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.CodeCommitSource", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Stage\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.CodeCommitSourceProps\"}}]")]
    public class CodeCommitSource : Source
    {
        public CodeCommitSource(Stage parent, string name, ICodeCommitSourceProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected CodeCommitSource(ByRefValue reference): base(reference)
        {
        }

        protected CodeCommitSource(DeputyProps props): base(props)
        {
        }
    }
}