using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Resources
{
    [JsiiInterface("@aws-cdk/resources", "jsii$_aws_cdk_resources$.PropertySpecification")]
    public interface IPropertySpecification
    {
        [JsiiProperty("isRequired", "{\"primitive\":\"boolean\"}")]
        bool IsRequired
        {
            get;
        }

        [JsiiProperty("updateType", "{\"primitive\":\"string\"}")]
        string UpdateType
        {
            get;
        }
    }
}