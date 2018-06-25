using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.Program", "[{\"name\":\"argv\",\"type\":{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}},\"optional\":true}}]")]
    public class Program : App
    {
        public Program(string[] argv): base(new DeputyProps(new object[]{argv}))
        {
        }

        protected Program(ByRefValue reference): base(reference)
        {
        }

        protected Program(DeputyProps props): base(props)
        {
        }
    }
}