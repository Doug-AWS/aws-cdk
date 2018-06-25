using Aws.Cdk;
using Aws.Cdk.Resources.sqs;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sqs
{
    /// <summary>Reference to a new or existing Amazon SQS queue</summary>
    [JsiiClass("@aws-cdk/sqs", "jsii$_aws_cdk_sqs$.QueueRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class QueueRef : Construct
    {
        protected QueueRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected QueueRef(ByRefValue reference): base(reference)
        {
        }

        protected QueueRef(DeputyProps props): base(props)
        {
        }

        /// <summary>The ARN of this queue</summary>
        [JsiiProperty("queueArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.sqs.QueueArn\"}")]
        public virtual QueueArn QueueArn
        {
            get => GetProperty<QueueArn>();
        }

        /// <summary>The URL of this queue</summary>
        [JsiiProperty("queueUrl", "{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueUrl\"}")]
        public virtual QueueUrl QueueUrl
        {
            get => GetProperty<QueueUrl>();
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

        /// <summary>Import an existing queue</summary>
        [JsiiMethod("import", null, "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueRefProps\"}}]")]
        public virtual void Import(Construct parent, string name, IQueueRefProps props)
        {
            InvokeVoidMethod(new object[]{parent, name, props});
        }

        /// <summary>Export a queue</summary>
        [JsiiMethod("export", "{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueRefProps\"}", "[]")]
        public virtual IQueueRefProps Export()
        {
            return InvokeMethod<IQueueRefProps>(new object[]{});
        }

        /// <summary>
        /// Adds a statement to the IAM resource policy associated with this queue.
        /// 
        /// If this queue was created in this stack (`new Queue`), a queue policy
        /// will be automatically created upon the first call to `addToPolicy`. If
        /// the queue is improted (`Queue.import`), then this is a no-op.
        /// </summary>
        [JsiiMethod("addToResourcePolicy", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddToResourcePolicy(PolicyStatement statement)
        {
            InvokeVoidMethod(new object[]{statement});
        }
    }
}