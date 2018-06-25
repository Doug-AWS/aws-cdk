using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.ValidationError", "[{\"name\":\"source\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"message\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ValidationError : DeputyBase
    {
        public ValidationError(Construct source, string message): base(new DeputyProps(new object[]{source, message}))
        {
        }

        protected ValidationError(ByRefValue reference): base(reference)
        {
        }

        protected ValidationError(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("source", "{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}")]
        public virtual Construct Source
        {
            get => GetProperty<Construct>();
        }

        [JsiiProperty("message", "{\"primitive\":\"string\"}")]
        public virtual string Message
        {
            get => GetProperty<string>();
        }
    }
}