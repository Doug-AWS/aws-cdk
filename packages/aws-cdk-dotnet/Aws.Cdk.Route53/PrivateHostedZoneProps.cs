using Aws.Cdk.Ec2;
using Aws.Cdk.Resources.logs;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Route53
{
    /// <summary>Properties for a private hosted zone.</summary>
    public class PrivateHostedZoneProps : DeputyBase, IPrivateHostedZoneProps
    {
        /// <summary>One VPC that you want to associate with this hosted zone.</summary>
        [JsiiProperty("vpc", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}", true)]
        public VpcNetworkRef Vpc
        {
            get;
            set;
        }

        /// <summary>The fully qualified domain name for the hosted zone</summary>
        [JsiiProperty("zoneName", "{\"primitive\":\"string\"}", true)]
        public string ZoneName
        {
            get;
            set;
        }

        /// <summary>Any comments that you want to include about the hosted zone.</summary>
        /// <remarks>default: no comment</remarks>
        [JsiiProperty("comment", "{\"primitive\":\"string\",\"optional\":true}", true)]
        public string Comment
        {
            get;
            set;
        }

        /// <summary>The Amazon Resource Name (ARN) for the log group that you want Amazon Route 53 to send query logs to.</summary>
        /// <remarks>default: no DNS query logging</remarks>
        [JsiiProperty("queryLogsLogGroupArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.logs.LogGroupArn\",\"optional\":true}", true)]
        public LogGroupArn QueryLogsLogGroupArn
        {
            get;
            set;
        }
    }
}