using AWS.Cdk.Resources.sqs;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sqs
{
    /// <summary>Reference to a queue</summary>
    public class QueueRefProps : DeputyBase, IQueueRefProps
    {
        [JsiiProperty("queueArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.sqs.QueueArn\"}", true)]
        public QueueArn QueueArn
        {
            get;
            set;
        }

        [JsiiProperty("queueUrl", "{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueUrl\"}", true)]
        public QueueUrl QueueUrl
        {
            get;
            set;
        }
    }
}