using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CxApi
{
    [JsiiInterface("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.ListStacksResponse")]
    public interface IListStacksResponse
    {
        [JsiiProperty("stacks", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.StackInfo\"}}}")]
        IStackInfo[] Stacks
        {
            get;
            set;
        }
    }
}