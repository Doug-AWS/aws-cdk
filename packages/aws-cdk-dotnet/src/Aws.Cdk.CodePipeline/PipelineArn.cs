using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <summary>The ARN of a pipeline</summary>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.PipelineArn", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class PipelineArn : Arn
    {
        public PipelineArn(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected PipelineArn(ByRefValue reference): base(reference)
        {
        }

        protected PipelineArn(DeputyProps props): base(props)
        {
        }
    }
}