using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CxApi
{
    [JsiiInterface("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.SynthesizeResponse")]
    public interface ISynthesizeResponse
    {
        [JsiiProperty("stacks", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.SynthesizedStack\"}}}")]
        ISynthesizedStack[] Stacks
        {
            get;
            set;
        }
    }
}