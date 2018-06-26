using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace AWS.Cdk.CxApi
{
    /// <summary>A complete synthesized stack</summary>
    [JsiiInterface("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.SynthesizedStack")]
    public interface ISynthesizedStack : IStackInfo
    {
        [JsiiProperty("missing", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.MissingContext\"}},\"optional\":true}")]
        IDictionary<string, IMissingContext> Missing
        {
            get;
            set;
        }

        [JsiiProperty("metadata", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.MetadataEntry\"}}}}}")]
        IDictionary<string, IMetadataEntry[]> Metadata
        {
            get;
            set;
        }

        [JsiiProperty("template", "{\"primitive\":\"any\"}")]
        object Template
        {
            get;
            set;
        }
    }
}