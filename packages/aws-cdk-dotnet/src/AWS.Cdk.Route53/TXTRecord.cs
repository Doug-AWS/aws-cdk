using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Route53
{
    /// <summary>A DNS TXT record</summary>
    [JsiiClass("@aws-cdk/route53", "jsii$_aws_cdk_route53$.TXTRecord", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_route53$.HostedZoneRef\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_route53$.TXTRecordProps\"}}]")]
    public class TXTRecord : Construct
    {
        public TXTRecord(HostedZoneRef parent, string name, ITXTRecordProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected TXTRecord(ByRefValue reference): base(reference)
        {
        }

        protected TXTRecord(DeputyProps props): base(props)
        {
        }
    }
}