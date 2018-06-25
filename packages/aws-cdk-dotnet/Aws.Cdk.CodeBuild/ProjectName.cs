using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.ProjectName", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class ProjectName : Token
    {
        public ProjectName(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected ProjectName(ByRefValue reference): base(reference)
        {
        }

        protected ProjectName(DeputyProps props): base(props)
        {
        }
    }
}