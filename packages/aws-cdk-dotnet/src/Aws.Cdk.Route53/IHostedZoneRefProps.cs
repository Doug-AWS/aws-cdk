using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Route53
{
    /// <summary>Reference to a hosted zone</summary>
    [JsiiInterface("@aws-cdk/route53", "jsii$_aws_cdk_route53$.HostedZoneRefProps")]
    public interface IHostedZoneRefProps
    {
        /// <summary>Identifier of the hosted zone</summary>
        [JsiiProperty("hostedZoneId", "{\"fqn\":\"jsii$_aws_cdk_route53$.HostedZoneId\"}")]
        HostedZoneId HostedZoneId
        {
            get;
            set;
        }

        /// <summary>Name of the hosted zone</summary>
        [JsiiProperty("zoneName", "{\"primitive\":\"string\"}")]
        string ZoneName
        {
            get;
            set;
        }
    }
}