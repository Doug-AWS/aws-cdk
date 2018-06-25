using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.ResourceProps")]
    public class ResourcePropsProxy : DeputyBase, IResourceProps
    {
        private ResourcePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>CloudFormation resource type.</summary>
        [JsiiProperty("type", "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>CloudFormation properties.</summary>
        [JsiiProperty("properties", "{\"primitive\":\"any\",\"optional\":true}")]
        public virtual object Properties
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }
    }
}