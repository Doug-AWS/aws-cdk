using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace AWS.Cdk.Resources
{
    [JsiiInterfaceProxy("@aws-cdk/resources", "jsii$_aws_cdk_resources$.ResourceClass")]
    public class ResourceClassProxy : DeputyBase, IResourceClass
    {
        private ResourceClassProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("resourceProperties", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_resources$.PropertySpecification\",\"optional\":true}}}")]
        public virtual IDictionary<string, IPropertySpecification> ResourceProperties
        {
            get => GetProperty<IDictionary<string, IPropertySpecification>>();
        }

        [JsiiProperty("resourceTypeName", "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeName
        {
            get => GetProperty<string>();
        }
    }
}