using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Rtv
{
    public class RuntimeValueProps : DeputyBase, IRuntimeValueProps
    {
        [JsiiProperty("package", "{\"primitive\":\"string\"}", true)]
        public string Package
        {
            get;
            set;
        }

        [JsiiProperty("value", "{\"primitive\":\"any\"}", true)]
        public object Value
        {
            get;
            set;
        }
    }
}