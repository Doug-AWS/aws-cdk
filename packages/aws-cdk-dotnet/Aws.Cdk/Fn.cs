using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// CloudFormation intrinsic functions.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference.html
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.Fn", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"value\",\"type\":{\"primitive\":\"any\"}}]")]
    public class Fn : Token
    {
        public Fn(string name, object value): base(new DeputyProps(new object[]{name, value}))
        {
        }

        protected Fn(ByRefValue reference): base(reference)
        {
        }

        protected Fn(DeputyProps props): base(props)
        {
        }
    }
}