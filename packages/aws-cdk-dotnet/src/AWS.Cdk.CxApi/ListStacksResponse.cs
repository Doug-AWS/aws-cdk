using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CxApi
{
    public class ListStacksResponse : DeputyBase, IListStacksResponse
    {
        [JsiiProperty("stacks", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.StackInfo\"}}}", true)]
        public IStackInfo[] Stacks
        {
            get;
            set;
        }
    }
}