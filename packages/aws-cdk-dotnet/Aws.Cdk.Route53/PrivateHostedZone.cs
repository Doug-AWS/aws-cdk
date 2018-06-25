using Aws.Cdk;
using Aws.Cdk.Ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Route53
{
    /// <summary>
    /// Create a Route53 private hosted zone for use in one or more VPCs.
    /// 
    /// Note that `enableDnsHostnames` and `enableDnsSupport` must have been enabled
    /// for the VPC you're configuring for private hosted zones.
    /// </summary>
    [JsiiClass("@aws-cdk/route53", "jsii$_aws_cdk_route53$.PrivateHostedZone", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_route53$.PrivateHostedZoneProps\"}}]")]
    public class PrivateHostedZone : HostedZoneRef
    {
        public PrivateHostedZone(Construct parent, string name, IPrivateHostedZoneProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected PrivateHostedZone(ByRefValue reference): base(reference)
        {
        }

        protected PrivateHostedZone(DeputyProps props): base(props)
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

        /// <summary>Add another VPC to this private hosted zone.</summary>
        /// <param name = "vpc">the other VPC to add.</param>
        [JsiiMethod("addVpc", null, "[{\"name\":\"vpc\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}}]")]
        public virtual void AddVpc(VpcNetworkRef vpc)
        {
            InvokeVoidMethod(new object[]{vpc});
        }
    }
}