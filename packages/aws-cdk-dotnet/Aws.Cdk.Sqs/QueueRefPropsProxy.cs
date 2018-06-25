using Aws.Cdk.Resources.sqs;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sqs
{
    /// <summary>Reference to a queue</summary>
    [JsiiInterfaceProxy("@aws-cdk/sqs", "jsii$_aws_cdk_sqs$.QueueRefProps")]
    public class QueueRefPropsProxy : DeputyBase, IQueueRefProps
    {
        private QueueRefPropsProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("queueArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.sqs.QueueArn\"}")]
        public virtual QueueArn QueueArn
        {
            get => GetProperty<QueueArn>();
            set => SetProperty(value);
        }

        [JsiiProperty("queueUrl", "{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueUrl\"}")]
        public virtual QueueUrl QueueUrl
        {
            get => GetProperty<QueueUrl>();
            set => SetProperty(value);
        }
    }
}