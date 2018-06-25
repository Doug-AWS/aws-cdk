using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Iam
{
    [JsiiClass("@aws-cdk/iam", "jsii$_aws_cdk_iam$.UserName", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class UserName : Token
    {
        public UserName(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected UserName(ByRefValue reference): base(reference)
        {
        }

        protected UserName(DeputyProps props): base(props)
        {
        }
    }
}