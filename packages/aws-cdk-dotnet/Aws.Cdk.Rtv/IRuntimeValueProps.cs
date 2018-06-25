using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rtv
{
    [JsiiInterface("@aws-cdk/rtv", "jsii$_aws_cdk_rtv$.RuntimeValueProps")]
    public interface IRuntimeValueProps
    {
        [JsiiProperty("package", "{\"primitive\":\"string\"}")]
        string Package
        {
            get;
            set;
        }

        [JsiiProperty("value", "{\"primitive\":\"any\"}")]
        object Value
        {
            get;
            set;
        }
    }
}