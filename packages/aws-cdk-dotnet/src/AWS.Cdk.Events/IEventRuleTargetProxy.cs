using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Events
{
    /// <summary>An abstract target for EventRules.</summary>
    [JsiiInterfaceProxy("@aws-cdk/events", "jsii$_aws_cdk_events$.IEventRuleTarget")]
    public class IEventRuleTargetProxy : DeputyBase, IIEventRuleTarget
    {
        private IEventRuleTargetProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// Returns the rule target specification.
        /// NOTE: Do not use the various `inputXxx` options. They can be set in a call to `addTarget`.
        /// </summary>
        [JsiiProperty("eventRuleTarget", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleTarget\"}")]
        public virtual IEventRuleTarget EventRuleTarget
        {
            get => GetProperty<IEventRuleTarget>();
        }
    }
}