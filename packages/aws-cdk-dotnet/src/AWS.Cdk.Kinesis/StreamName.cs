using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Kinesis
{
    /// <summary>The name of the stream.</summary>
    [JsiiClass("@aws-cdk/kinesis", "jsii$_aws_cdk_kinesis$.StreamName", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class StreamName : Token
    {
        public StreamName(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected StreamName(ByRefValue reference): base(reference)
        {
        }

        protected StreamName(DeputyProps props): base(props)
        {
        }
    }
}