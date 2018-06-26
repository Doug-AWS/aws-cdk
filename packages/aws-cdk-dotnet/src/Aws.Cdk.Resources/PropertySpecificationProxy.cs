using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Resources
{
    [JsiiInterfaceProxy("@aws-cdk/resources", "jsii$_aws_cdk_resources$.PropertySpecification")]
    public class PropertySpecificationProxy : DeputyBase, IPropertySpecification
    {
        private PropertySpecificationProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("isRequired", "{\"primitive\":\"boolean\"}")]
        public virtual bool IsRequired
        {
            get => GetProperty<bool>();
        }

        [JsiiProperty("updateType", "{\"primitive\":\"string\"}")]
        public virtual string UpdateType
        {
            get => GetProperty<string>();
        }
    }
}