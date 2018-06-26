using AWS.Cdk;
using AWS.Cdk.Resources.events;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Events
{
    [JsiiClass("@aws-cdk/events", "jsii$_aws_cdk_events$.EventRuleRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class EventRuleRef : Construct
    {
        protected EventRuleRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected EventRuleRef(ByRefValue reference): base(reference)
        {
        }

        protected EventRuleRef(DeputyProps props): base(props)
        {
        }

        /// <summary>
        /// The value of the event rule Amazon Resource Name (ARN), such as
        /// arn:aws:events:us-east-2:123456789012:rule/example.
        /// </summary>
        [JsiiProperty("ruleArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.events.RuleArn\"}")]
        public virtual RuleArn RuleArn
        {
            get => GetProperty<RuleArn>();
        }

        /// <summary>Imports a rule by ARN into this stack.</summary>
        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleRefProps\"}}]")]
        public virtual EventRuleRef Import(Construct parent, string name, IEventRuleRefProps props)
        {
            return InvokeMethod<EventRuleRef>(new object[]{parent, name, props});
        }

        /// <summary>Exports this rule resource from this stack and returns an import token.</summary>
        [JsiiMethod("export", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleRefProps\"}", "[]")]
        public virtual IEventRuleRefProps Export()
        {
            return InvokeMethod<IEventRuleRefProps>(new object[]{});
        }
    }
}