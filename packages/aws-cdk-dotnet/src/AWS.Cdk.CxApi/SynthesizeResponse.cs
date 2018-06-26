using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CxApi
{
    public class SynthesizeResponse : DeputyBase, ISynthesizeResponse
    {
        [JsiiProperty("stacks", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.SynthesizedStack\"}}}", true)]
        public ISynthesizedStack[] Stacks
        {
            get;
            set;
        }
    }
}