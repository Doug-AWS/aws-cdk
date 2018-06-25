using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Aws.Cdk
{
    [JsiiInterface("@aws-cdk/core", "jsii$_aws_cdk_core$.MappingProps")]
    public interface IMappingProps
    {
        [JsiiProperty("mapping", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}},\"optional\":true}")]
        IDictionary<string, IDictionary<string, object>> Mapping
        {
            get;
            set;
        }
    }
}