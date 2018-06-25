using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html </remarks>
    public class Tag : DeputyBase, ITag
    {
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html#cfn-resource-tags-key </remarks>
        [JsiiProperty("key", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}]}}", true)]
        public object Key
        {
            get;
            set;
        }

        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html#cfn-resource-tags-value </remarks>
        [JsiiProperty("value", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}]}}", true)]
        public object Value
        {
            get;
            set;
        }
    }
}