using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rds
{
    /// <summary>A complete socket address (hostname + ":" + port)</summary>
    [JsiiClass("@aws-cdk/rds", "jsii$_aws_cdk_rds$.SocketAddress", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class SocketAddress : Token
    {
        public SocketAddress(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected SocketAddress(ByRefValue reference): base(reference)
        {
        }

        protected SocketAddress(DeputyProps props): base(props)
        {
        }
    }
}