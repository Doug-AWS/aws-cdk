using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rds
{
    /// <summary>An RDS username</summary>
    [JsiiClass("@aws-cdk/rds", "jsii$_aws_cdk_rds$.Username", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class Username : Token
    {
        public Username(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected Username(ByRefValue reference): base(reference)
        {
        }

        protected Username(DeputyProps props): base(props)
        {
        }
    }
}