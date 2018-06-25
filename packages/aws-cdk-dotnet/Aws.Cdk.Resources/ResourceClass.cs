using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Aws.Cdk.Resources
{
    public class ResourceClass : DeputyBase, IResourceClass
    {
        [JsiiProperty("resourceProperties", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_resources$.PropertySpecification\",\"optional\":true}}}", true)]
        public IDictionary<string, IPropertySpecification> ResourceProperties
        {
            get;
        }

        [JsiiProperty("resourceTypeName", "{\"primitive\":\"string\"}", true)]
        public string ResourceTypeName
        {
            get;
        }
    }
}