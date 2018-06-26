using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Route53
{
    /// <summary>Reference to a hosted zone</summary>
    [JsiiInterfaceProxy("@aws-cdk/route53", "jsii$_aws_cdk_route53$.HostedZoneRefProps")]
    public class HostedZoneRefPropsProxy : DeputyBase, IHostedZoneRefProps
    {
        private HostedZoneRefPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Identifier of the hosted zone</summary>
        [JsiiProperty("hostedZoneId", "{\"fqn\":\"jsii$_aws_cdk_route53$.HostedZoneId\"}")]
        public virtual HostedZoneId HostedZoneId
        {
            get => GetProperty<HostedZoneId>();
            set => SetProperty(value);
        }

        /// <summary>Name of the hosted zone</summary>
        [JsiiProperty("zoneName", "{\"primitive\":\"string\"}")]
        public virtual string ZoneName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}