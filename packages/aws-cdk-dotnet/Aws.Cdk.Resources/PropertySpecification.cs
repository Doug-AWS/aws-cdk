using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Resources
{
    public class PropertySpecification : DeputyBase, IPropertySpecification
    {
        [JsiiProperty("isRequired", "{\"primitive\":\"boolean\"}", true)]
        public bool IsRequired
        {
            get;
        }

        [JsiiProperty("updateType", "{\"primitive\":\"string\"}", true)]
        public string UpdateType
        {
            get;
        }
    }
}