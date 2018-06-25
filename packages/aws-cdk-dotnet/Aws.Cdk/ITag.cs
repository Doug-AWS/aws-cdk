using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html </remarks>
    [JsiiInterface("@aws-cdk/core", "jsii$_aws_cdk_core$.Tag")]
    public interface ITag
    {
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html#cfn-resource-tags-key </remarks>
        [JsiiProperty("key", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}]}}")]
        object Key
        {
            get;
            set;
        }

        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html#cfn-resource-tags-value </remarks>
        [JsiiProperty("value", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}]}}")]
        object Value
        {
            get;
            set;
        }
    }
}