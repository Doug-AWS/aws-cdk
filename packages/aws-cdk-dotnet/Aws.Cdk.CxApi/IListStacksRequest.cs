using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CxApi
{
    [JsiiInterface("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.ListStacksRequest")]
    public interface IListStacksRequest
    {
        [JsiiProperty("type", "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
            set;
        }

        [JsiiProperty("context", "{\"primitive\":\"any\",\"optional\":true}")]
        object Context
        {
            get;
            set;
        }
    }
}