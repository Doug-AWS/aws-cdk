using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Rds
{
    /// <summary>Port part of an address</summary>
    [JsiiClass("@aws-cdk/rds", "jsii$_aws_cdk_rds$.Port", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class Port : Token
    {
        public Port(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected Port(ByRefValue reference): base(reference)
        {
        }

        protected Port(DeputyProps props): base(props)
        {
        }
    }
}