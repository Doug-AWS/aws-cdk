using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CxApi
{
    /// <summary>Identifies a single stack</summary>
    [JsiiInterface("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.StackId")]
    public interface IStackId
    {
        [JsiiProperty("name", "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
            set;
        }
    }
}