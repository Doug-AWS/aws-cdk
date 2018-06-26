using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sns
{
    /// <summary>ARN of a Topic</summary>
    [JsiiClass("@aws-cdk/sns", "jsii$_aws_cdk_sns$.TopicArn", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class TopicArn : Arn
    {
        public TopicArn(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected TopicArn(ByRefValue reference): base(reference)
        {
        }

        protected TopicArn(DeputyProps props): base(props)
        {
        }
    }
}