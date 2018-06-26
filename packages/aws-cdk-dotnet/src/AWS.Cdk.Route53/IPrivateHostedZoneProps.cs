using AWS.Cdk.Ec2;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Route53
{
    /// <summary>Properties for a private hosted zone.</summary>
    [JsiiInterface("@aws-cdk/route53", "jsii$_aws_cdk_route53$.PrivateHostedZoneProps")]
    public interface IPrivateHostedZoneProps : IPublicHostedZoneProps
    {
        /// <summary>One VPC that you want to associate with this hosted zone.</summary>
        [JsiiProperty("vpc", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}")]
        VpcNetworkRef Vpc
        {
            get;
            set;
        }
    }
}