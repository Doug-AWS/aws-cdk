using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Iam
{
    [JsiiClass("@aws-cdk/iam", "jsii$_aws_cdk_iam$.RoleName", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class RoleName : Token
    {
        public RoleName(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected RoleName(ByRefValue reference): base(reference)
        {
        }

        protected RoleName(DeputyProps props): base(props)
        {
        }
    }
}