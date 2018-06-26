using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Route53
{
    /// <summary>Create a Route53 public hosted zone.</summary>
    [JsiiClass("@aws-cdk/route53", "jsii$_aws_cdk_route53$.PublicHostedZone", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_route53$.PublicHostedZoneProps\"}}]")]
    public class PublicHostedZone : HostedZoneRef
    {
        public PublicHostedZone(Construct parent, string name, IPublicHostedZoneProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected PublicHostedZone(ByRefValue reference): base(reference)
        {
        }

        protected PublicHostedZone(DeputyProps props): base(props)
        {
        }

        /// <summary>Identifier of this hosted zone</summary>
        [JsiiProperty("hostedZoneId", "{\"fqn\":\"jsii$_aws_cdk_route53$.HostedZoneId\"}")]
        public override HostedZoneId HostedZoneId
        {
            get => GetProperty<HostedZoneId>();
        }

        /// <summary>Fully qualified domain name for the hosted zone</summary>
        [JsiiProperty("zoneName", "{\"primitive\":\"string\"}")]
        public override string ZoneName
        {
            get => GetProperty<string>();
        }

        /// <summary>Nameservers for this public hosted zone</summary>
        [JsiiProperty("nameServers", "{\"fqn\":\"jsii$_aws_cdk_route53$.HostedZoneNameServers\"}")]
        public virtual HostedZoneNameServers NameServers
        {
            get => GetProperty<HostedZoneNameServers>();
        }
    }
}