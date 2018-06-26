using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Events
{
    /// <summary>An abstract target for EventRules.</summary>
    public class IEventRuleTarget : DeputyBase, IIEventRuleTarget
    {
        /// <summary>
        /// Returns the rule target specification.
        /// NOTE: Do not use the various `inputXxx` options. They can be set in a call to `addTarget`.
        /// </summary>
        [JsiiProperty("eventRuleTarget", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleTarget\"}", true)]
        public IEventRuleTarget EventRuleTarget
        {
            get;
        }
    }
}