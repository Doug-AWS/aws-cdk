using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sqs
{
    /// <summary>URL of a queue</summary>
    [JsiiClass("@aws-cdk/sqs", "jsii$_aws_cdk_sqs$.QueueUrl", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class QueueUrl : Token
    {
        public QueueUrl(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected QueueUrl(ByRefValue reference): base(reference)
        {
        }

        protected QueueUrl(DeputyProps props): base(props)
        {
        }
    }
}