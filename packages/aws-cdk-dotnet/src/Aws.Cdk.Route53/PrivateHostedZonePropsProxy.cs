using Aws.Cdk.Ec2;
using Aws.Cdk.Resources.logs;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Route53
{
    /// <summary>Properties for a private hosted zone.</summary>
    [JsiiInterfaceProxy("@aws-cdk/route53", "jsii$_aws_cdk_route53$.PrivateHostedZoneProps")]
    public class PrivateHostedZonePropsProxy : DeputyBase, IPrivateHostedZoneProps
    {
        private PrivateHostedZonePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>One VPC that you want to associate with this hosted zone.</summary>
        [JsiiProperty("vpc", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}")]
        public virtual VpcNetworkRef Vpc
        {
            get => GetProperty<VpcNetworkRef>();
            set => SetProperty(value);
        }

        /// <summary>The fully qualified domain name for the hosted zone</summary>
        [JsiiProperty("zoneName", "{\"primitive\":\"string\"}")]
        public virtual string ZoneName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Any comments that you want to include about the hosted zone.</summary>
        /// <remarks>default: no comment</remarks>
        [JsiiProperty("comment", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Comment
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The Amazon Resource Name (ARN) for the log group that you want Amazon Route 53 to send query logs to.</summary>
        /// <remarks>default: no DNS query logging</remarks>
        [JsiiProperty("queryLogsLogGroupArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.logs.LogGroupArn\",\"optional\":true}")]
        public virtual LogGroupArn QueryLogsLogGroupArn
        {
            get => GetProperty<LogGroupArn>();
            set => SetProperty(value);
        }
    }
}