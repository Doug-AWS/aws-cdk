using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html </remarks>
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.Tag")]
    public class TagProxy : DeputyBase, ITag
    {
        private TagProxy(ByRefValue reference): base(reference)
        {
        }

        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html#cfn-resource-tags-key </remarks>
        [JsiiProperty("key", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}]}}")]
        public virtual object Key
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }

        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html#cfn-resource-tags-value </remarks>
        [JsiiProperty("value", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}]}}")]
        public virtual object Value
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }
    }
}