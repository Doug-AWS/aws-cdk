using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace AWS.Cdk.Resources
{
    [JsiiInterface("@aws-cdk/resources", "jsii$_aws_cdk_resources$.ResourceClass")]
    public interface IResourceClass
    {
        [JsiiProperty("resourceProperties", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_resources$.PropertySpecification\",\"optional\":true}}}")]
        IDictionary<string, IPropertySpecification> ResourceProperties
        {
            get;
        }

        [JsiiProperty("resourceTypeName", "{\"primitive\":\"string\"}")]
        string ResourceTypeName
        {
            get;
        }
    }
}