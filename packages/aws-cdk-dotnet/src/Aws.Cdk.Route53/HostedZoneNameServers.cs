using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Route53
{
    [JsiiClass("@aws-cdk/route53", "jsii$_aws_cdk_route53$.HostedZoneNameServers", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class HostedZoneNameServers : Token
    {
        public HostedZoneNameServers(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected HostedZoneNameServers(ByRefValue reference): base(reference)
        {
        }

        protected HostedZoneNameServers(DeputyProps props): base(props)
        {
        }
    }
}