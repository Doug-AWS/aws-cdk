using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rds
{
    /// <summary>Identifier of a cluster</summary>
    [JsiiClass("@aws-cdk/rds", "jsii$_aws_cdk_rds$.ClusterIdentifier", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class ClusterIdentifier : Token
    {
        public ClusterIdentifier(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected ClusterIdentifier(ByRefValue reference): base(reference)
        {
        }

        protected ClusterIdentifier(DeputyProps props): base(props)
        {
        }
    }
}