using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Rds
{
    /// <summary>Identifier of an instance</summary>
    [JsiiClass("@aws-cdk/rds", "jsii$_aws_cdk_rds$.InstanceIdentifier", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class InstanceIdentifier : Token
    {
        public InstanceIdentifier(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected InstanceIdentifier(ByRefValue reference): base(reference)
        {
        }

        protected InstanceIdentifier(DeputyProps props): base(props)
        {
        }
    }
}