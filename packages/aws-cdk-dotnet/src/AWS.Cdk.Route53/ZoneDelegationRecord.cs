using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Route53
{
    /// <summary>A record to delegate further lookups to a different set of name servers</summary>
    [JsiiClass("@aws-cdk/route53", "jsii$_aws_cdk_route53$.ZoneDelegationRecord", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_route53$.HostedZoneRef\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_route53$.ZoneDelegationRecordProps\"}}]")]
    public class ZoneDelegationRecord : Construct
    {
        public ZoneDelegationRecord(HostedZoneRef parent, string name, IZoneDelegationRecordProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected ZoneDelegationRecord(ByRefValue reference): base(reference)
        {
        }

        protected ZoneDelegationRecord(DeputyProps props): base(props)
        {
        }
    }
}