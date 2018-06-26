using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Events
{
    /// <summary>An abstract target for EventRules.</summary>
    [JsiiInterface("@aws-cdk/events", "jsii$_aws_cdk_events$.IEventRuleTarget")]
    public interface IIEventRuleTarget
    {
        /// <summary>
        /// Returns the rule target specification.
        /// NOTE: Do not use the various `inputXxx` options. They can be set in a call to `addTarget`.
        /// </summary>
        [JsiiProperty("eventRuleTarget", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleTarget\"}")]
        IEventRuleTarget EventRuleTarget
        {
            get;
        }
    }
}