using AWS.Cdk;
using AWS.Cdk.Events;
using AWS.Cdk.Iam;
using AWS.Cdk.Lambda;
using AWS.Cdk.Sqs;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sns
{
    /// <summary>Either a new or imported Topic</summary>
    [JsiiClass("@aws-cdk/sns", "jsii$_aws_cdk_sns$.TopicRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class TopicRef : Construct, IIEventRuleTarget
    {
        protected TopicRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected TopicRef(ByRefValue reference): base(reference)
        {
        }

        protected TopicRef(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("topicArn", "{\"fqn\":\"jsii$_aws_cdk_sns$.TopicArn\"}")]
        public virtual TopicArn TopicArn
        {
            get => GetProperty<TopicArn>();
        }

        /// <summary>
        /// Controls automatic creation of policy objects.
        /// 
        /// Set by subclasses.
        /// </summary>
        [JsiiProperty("autoCreatePolicy", "{\"primitive\":\"boolean\"}")]
        protected virtual bool AutoCreatePolicy
        {
            get => GetProperty<bool>();
        }

        /// <summary>
        /// Returns a RuleTarget that can be used to trigger this SNS topic as a
        /// result from a CloudWatch event.
        /// </summary>
        [JsiiProperty("eventRuleTarget", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleTarget\"}")]
        public virtual IEventRuleTarget EventRuleTarget
        {
            get => GetProperty<IEventRuleTarget>();
        }

        /// <summary>Import a Topic defined elsewhere</summary>
        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_sns$.TopicRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_sns$.TopicRefProps\"}}]")]
        public virtual TopicRef Import(Construct parent, string name, ITopicRefProps props)
        {
            return InvokeMethod<TopicRef>(new object[]{parent, name, props});
        }

        /// <summary>Export this Topic</summary>
        [JsiiMethod("export", "{\"fqn\":\"jsii$_aws_cdk_sns$.TopicRefProps\"}", "[]")]
        public virtual ITopicRefProps Export()
        {
            return InvokeMethod<ITopicRefProps>(new object[]{});
        }

        /// <summary>Subscribe some endpoint to this topic</summary>
        [JsiiMethod("subscribe", null, "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"endpoint\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"protocol\",\"type\":{\"fqn\":\"jsii$_aws_cdk_sns$.SubscriptionProtocol\"}}]")]
        public virtual void Subscribe(string name, string endpoint, SubscriptionProtocol protocol)
        {
            InvokeVoidMethod(new object[]{name, endpoint, protocol});
        }

        /// <summary>
        /// Defines a subscription from this SNS topic to an SQS queue.
        /// 
        /// The queue resource policy will be updated to allow this SNS topic to send
        /// messages to the queue.
        /// 
        /// TODO: change to QueueRef.
        /// </summary>
        /// <param name = "queue">The target queue</param>
        [JsiiMethod("subscribeQueue", "{\"fqn\":\"jsii$_aws_cdk_sns$.Subscription\"}", "[{\"name\":\"queue\",\"type\":{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueRef\"}}]")]
        public virtual Subscription SubscribeQueue(QueueRef queue)
        {
            return InvokeMethod<Subscription>(new object[]{queue});
        }

        /// <summary>
        /// Defines a subscription from this SNS Topic to a Lambda function.
        /// 
        /// The Lambda's resource policy will be updated to allow this topic to
        /// invoke the function.
        /// </summary>
        /// <param name = "lambdaFunction">The Lambda function to invoke</param>
        [JsiiMethod("subscribeLambda", "{\"fqn\":\"jsii$_aws_cdk_sns$.Subscription\"}", "[{\"name\":\"lambdaFunction\",\"type\":{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRef\"}}]")]
        public virtual Subscription SubscribeLambda(LambdaRef lambdaFunction)
        {
            return InvokeMethod<Subscription>(new object[]{lambdaFunction});
        }

        /// <summary>Defines a subscription from this SNS topic to an email address.</summary>
        /// <param name = "name">A name for the subscription</param>
        /// <param name = "emailAddress">The email address to use.</param>
        [JsiiMethod("subscribeEmail", "{\"fqn\":\"jsii$_aws_cdk_sns$.Subscription\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"emailAddress\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_sns$.EmailSubscriptionOptions\",\"optional\":true}}]")]
        public virtual Subscription SubscribeEmail(string name, string emailAddress, IEmailSubscriptionOptions options)
        {
            return InvokeMethod<Subscription>(new object[]{name, emailAddress, options});
        }

        /// <summary>Defines a subscription from this SNS topic to an http:// or https:// URL.</summary>
        /// <param name = "name">A name for the subscription</param>
        /// <param name = "url">The URL to invoke</param>
        [JsiiMethod("subscribeUrl", "{\"fqn\":\"jsii$_aws_cdk_sns$.Subscription\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"url\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual Subscription SubscribeUrl(string name, string url)
        {
            return InvokeMethod<Subscription>(new object[]{name, url});
        }

        /// <summary>
        /// Adds a statement to the IAM resource policy associated with this topic.
        /// 
        /// If this topic was created in this stack (`new Topic`), a topic policy
        /// will be automatically created upon the first call to `addToPolicy`. If
        /// the topic is improted (`Topic.import`), then this is a no-op.
        /// </summary>
        [JsiiMethod("addToResourcePolicy", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddToResourcePolicy(PolicyStatement statement)
        {
            InvokeVoidMethod(new object[]{statement});
        }

        /// <summary>Grant topic publishing permissions to the given identity</summary>
        [JsiiMethod("grantPublish", null, "[{\"name\":\"identity\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.IIdentityResource\",\"optional\":true}}]")]
        public virtual void GrantPublish(IIIdentityResource identity)
        {
            InvokeVoidMethod(new object[]{identity});
        }
    }
}