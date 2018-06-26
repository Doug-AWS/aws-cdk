using Aws.Cdk.Resources.sqs;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sqs
{
    /// <summary>Reference to a queue</summary>
    [JsiiInterface("@aws-cdk/sqs", "jsii$_aws_cdk_sqs$.QueueRefProps")]
    public interface IQueueRefProps
    {
        [JsiiProperty("queueArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.sqs.QueueArn\"}")]
        QueueArn QueueArn
        {
            get;
            set;
        }

        [JsiiProperty("queueUrl", "{\"fqn\":\"jsii$_aws_cdk_sqs$.QueueUrl\"}")]
        QueueUrl QueueUrl
        {
            get;
            set;
        }
    }
}