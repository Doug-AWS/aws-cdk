using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    [JsiiInterface("@aws-cdk/core", "jsii$_aws_cdk_core$.ResourceProps")]
    public interface IResourceProps
    {
        /// <summary>CloudFormation resource type.</summary>
        [JsiiProperty("type", "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
            set;
        }

        /// <summary>CloudFormation properties.</summary>
        [JsiiProperty("properties", "{\"primitive\":\"any\",\"optional\":true}")]
        object Properties
        {
            get;
            set;
        }
    }
}