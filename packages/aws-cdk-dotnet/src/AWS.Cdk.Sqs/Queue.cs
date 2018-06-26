using AWS.Cdk;
using AWS.Cdk.Resources.sqs;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sqs
{
    /// <summary>A new Amazon SQS queue</summary>
    [JsiiClass("@aws-cdk/sqs", "jsii$_aws_cdk_sqs$.Queue", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueProps\",\"optional\":true}}]")]
    public class Queue : QueueRef
    {
        public Queue(Construct parent, string name, IQueueProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Queue(ByRefValue reference): base(reference)
        {
        }

        protected Queue(DeputyProps props): base(props)
        {
        }

        /// <summary>The ARN of this queue</summary>
        [JsiiProperty("queueArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.sqs.QueueArn\"}")]
        public override QueueArn QueueArn
        {
            get => GetProperty<QueueArn>();
        }

        /// <summary>The name of this queue</summary>
        [JsiiProperty("queueName", "{\"fqn\":\"jsii$_aws_cdk_resources$.sqs.QueueName\"}")]
        public virtual QueueName QueueName
        {
            get => GetProperty<QueueName>();
        }

        /// <summary>The URL of this queue</summary>
        [JsiiProperty("queueUrl", "{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueUrl\"}")]
        public override QueueUrl QueueUrl
        {
            get => GetProperty<QueueUrl>();
        }

        /// <summary>
        /// Controls automatic creation of policy objects.
        /// 
        /// Set by subclasses.
        /// </summary>
        [JsiiProperty("autoCreatePolicy", "{\"primitive\":\"boolean\"}")]
        protected override bool AutoCreatePolicy
        {
            get => GetProperty<bool>();
        }
    }
}