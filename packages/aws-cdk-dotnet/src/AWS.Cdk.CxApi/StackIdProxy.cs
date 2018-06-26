using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CxApi
{
    /// <summary>Identifies a single stack</summary>
    [JsiiInterfaceProxy("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.StackId")]
    public class StackIdProxy : DeputyBase, IStackId
    {
        private StackIdProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("name", "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}