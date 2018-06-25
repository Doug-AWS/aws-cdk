using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rtv
{
    [JsiiInterfaceProxy("@aws-cdk/rtv", "jsii$_aws_cdk_rtv$.RuntimeValueProps")]
    public class RuntimeValuePropsProxy : DeputyBase, IRuntimeValueProps
    {
        private RuntimeValuePropsProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("package", "{\"primitive\":\"string\"}")]
        public virtual string Package
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("value", "{\"primitive\":\"any\"}")]
        public virtual object Value
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }
    }
}