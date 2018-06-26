using AWS.Cdk.Resources.events;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Events
{
    public class EventRuleRefProps : DeputyBase, IEventRuleRefProps
    {
        /// <summary>
        /// The value of the event rule Amazon Resource Name (ARN), such as
        /// arn:aws:events:us-east-2:123456789012:rule/example.
        /// </summary>
        [JsiiProperty("eventRuleArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.events.RuleArn\"}", true)]
        public RuleArn EventRuleArn
        {
            get;
            set;
        }
    }
}