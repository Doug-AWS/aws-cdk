using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Iam
{
    [JsiiClass("@aws-cdk/iam", "jsii$_aws_cdk_iam$.GroupName", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class GroupName : Token
    {
        public GroupName(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected GroupName(ByRefValue reference): base(reference)
        {
        }

        protected GroupName(DeputyProps props): base(props)
        {
        }
    }
}