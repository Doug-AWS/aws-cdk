using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Rds
{
    /// <summary>An RDS password</summary>
    [JsiiClass("@aws-cdk/rds", "jsii$_aws_cdk_rds$.Password", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class Password : Token
    {
        public Password(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected Password(ByRefValue reference): base(reference)
        {
        }

        protected Password(DeputyProps props): base(props)
        {
        }
    }
}