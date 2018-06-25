using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Route53
{
    /// <summary>Hosted zone identifier</summary>
    [JsiiClass("@aws-cdk/route53", "jsii$_aws_cdk_route53$.HostedZoneId", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class HostedZoneId : Token
    {
        public HostedZoneId(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected HostedZoneId(ByRefValue reference): base(reference)
        {
        }

        protected HostedZoneId(DeputyProps props): base(props)
        {
        }
    }
}