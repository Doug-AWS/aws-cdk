using Aws.Cdk.Resources.events;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Events
{
    [JsiiInterface("@aws-cdk/events", "jsii$_aws_cdk_events$.EventRuleRefProps")]
    public interface IEventRuleRefProps
    {
        /// <summary>
        /// The value of the event rule Amazon Resource Name (ARN), such as
        /// arn:aws:events:us-east-2:123456789012:rule/example.
        /// </summary>
        [JsiiProperty("eventRuleArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.events.RuleArn\"}")]
        RuleArn EventRuleArn
        {
            get;
            set;
        }
    }
}