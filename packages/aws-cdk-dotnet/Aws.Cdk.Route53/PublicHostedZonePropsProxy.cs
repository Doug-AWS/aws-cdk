using Aws.Cdk.Resources.logs;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Route53
{
    /// <summary>Properties of a new hosted zone</summary>
    [JsiiInterfaceProxy("@aws-cdk/route53", "jsii$_aws_cdk_route53$.PublicHostedZoneProps")]
    public class PublicHostedZonePropsProxy : DeputyBase, IPublicHostedZoneProps
    {
        private PublicHostedZonePropsProxy(ByRefValue reference): base(reference)
        {
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