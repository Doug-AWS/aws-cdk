using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CxApi
{
    [JsiiInterfaceProxy("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.ListStacksRequest")]
    public class ListStacksRequestProxy : DeputyBase, IListStacksRequest
    {
        private ListStacksRequestProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("type", "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("context", "{\"primitive\":\"any\",\"optional\":true}")]
        public virtual object Context
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }
    }
}