using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Events
{
    [JsiiInterfaceProxy("@aws-cdk/events", "jsii$_aws_cdk_events$.EventRuleProps")]
    public class EventRulePropsProxy : DeputyBase, IEventRuleProps
    {
        private EventRulePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>A description of the rule's purpose.</summary>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Description
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// A name for the rule. If you don't specify a name, AWS CloudFormation
        /// generates a unique physical ID and uses that ID for the rule name. For
        /// more information, see Name Type.
        /// </summary>
        [JsiiProperty("ruleName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string RuleName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Indicates whether the rule is enabled.</summary>
        /// <remarks>default: Rule is enabled</remarks>
        [JsiiProperty("enabled", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? Enabled
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// The schedule or rate (frequency) that determines when CloudWatch Events
        /// runs the rule. For more information, see Schedule Expression Syntax for
        /// Rules in the Amazon CloudWatch User Guide.
        /// </summary>
        /// <remarks>
        /// see: http://docs.aws.amazon.com/AmazonCloudWatch/latest/events/ScheduledEvents.html
        /// 
        /// You must specify this property, the `eventPattern` property, or both.
        /// </remarks>
        [JsiiProperty("scheduleExpression", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string ScheduleExpression
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Describes which events CloudWatch Events routes to the specified target.
        /// These routed events are matched events. For more information, see Events
        /// and Event Patterns in the Amazon CloudWatch User Guide.
        /// </summary>
        /// <remarks>
        /// see: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CloudWatchEventsandEventPatterns.html
        /// 
        /// You must specify this property (either via props or via
        /// `addEventPattern`), the `scheduleExpression` property, or both. The
        /// method `addEventPattern` can be used to add filter values to the event
        /// pattern.
        /// </remarks>
        [JsiiProperty("eventPattern", "{\"fqn\":\"jsii$_aws_cdk_events$.EventPattern\",\"optional\":true}")]
        public virtual IEventPattern EventPattern
        {
            get => GetProperty<IEventPattern>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Targets to invoke when this rule matches an event.
        /// 
        /// Input will be the full matched event. If you wish to specify custom
        /// target input, use `addTarget(target[, inputOptions])`.
        /// </summary>
        [JsiiProperty("targets", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\"}},\"optional\":true}")]
        public virtual IIEventRuleTarget[] Targets
        {
            get => GetProperty<IIEventRuleTarget[]>();
            set => SetProperty(value);
        }
    }
}