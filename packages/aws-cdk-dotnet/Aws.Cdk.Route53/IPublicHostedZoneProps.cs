using Aws.Cdk.Resources.logs;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Route53
{
    /// <summary>Properties of a new hosted zone</summary>
    [JsiiInterface("@aws-cdk/route53", "jsii$_aws_cdk_route53$.PublicHostedZoneProps")]
    public interface IPublicHostedZoneProps
    {
        /// <summary>The fully qualified domain name for the hosted zone</summary>
        [JsiiProperty("zoneName", "{\"primitive\":\"string\"}")]
        string ZoneName
        {
            get;
            set;
        }

        /// <summary>Any comments that you want to include about the hosted zone.</summary>
        /// <remarks>default: no comment</remarks>
        [JsiiProperty("comment", "{\"primitive\":\"string\",\"optional\":true}")]
        string Comment
        {
            get;
            set;
        }

        /// <summary>The Amazon Resource Name (ARN) for the log group that you want Amazon Route 53 to send query logs to.</summary>
        /// <remarks>default: no DNS query logging</remarks>
        [JsiiProperty("queryLogsLogGroupArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.logs.LogGroupArn\",\"optional\":true}")]
        LogGroupArn QueryLogsLogGroupArn
        {
            get;
            set;
        }
    }
}