using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CxApi
{
    public class ListStacksRequest : DeputyBase, IListStacksRequest
    {
        [JsiiProperty("type", "{\"primitive\":\"string\"}", true)]
        public string Type
        {
            get;
            set;
        }

        [JsiiProperty("context", "{\"primitive\":\"any\",\"optional\":true}", true)]
        public object Context
        {
            get;
            set;
        }
    }
}