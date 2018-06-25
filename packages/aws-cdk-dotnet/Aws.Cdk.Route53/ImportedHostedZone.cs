using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Route53
{
    /// <summary>Imported hosted zone</summary>
    [JsiiClass("@aws-cdk/route53", "jsii$_aws_cdk_route53$.ImportedHostedZone", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_route53$.HostedZoneRefProps\"}}]")]
    public class ImportedHostedZone : HostedZoneRef
    {
        public ImportedHostedZone(Construct parent, string name, IHostedZoneRefProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected ImportedHostedZone(ByRefValue reference): base(reference)
        {
        }

        protected ImportedHostedZone(DeputyProps props): base(props)
        {
        }

        /// <summary>ID of this hosted zone</summary>
        [JsiiProperty("hostedZoneId", "{\"fqn\":\"jsii$_aws_cdk_route53$.HostedZoneId\"}")]
        public override HostedZoneId HostedZoneId
        {
            get => GetProperty<HostedZoneId>();
        }

        /// <summary>FQDN of this hosted zone</summary>
        [JsiiProperty("zoneName", "{\"primitive\":\"string\"}")]
        public override string ZoneName
        {
            get => GetProperty<string>();
        }
    }
}