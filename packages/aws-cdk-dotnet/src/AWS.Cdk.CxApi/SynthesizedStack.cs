using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace AWS.Cdk.CxApi
{
    /// <summary>A complete synthesized stack</summary>
    public class SynthesizedStack : DeputyBase, ISynthesizedStack
    {
        [JsiiProperty("missing", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.MissingContext\"}},\"optional\":true}", true)]
        public IDictionary<string, IMissingContext> Missing
        {
            get;
            set;
        }

        [JsiiProperty("metadata", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.MetadataEntry\"}}}}}", true)]
        public IDictionary<string, IMetadataEntry[]> Metadata
        {
            get;
            set;
        }

        [JsiiProperty("template", "{\"primitive\":\"any\"}", true)]
        public object Template
        {
            get;
            set;
        }

        [JsiiProperty("environment", "{\"fqn\":\"jsii$_aws_cdk_cx_api$.Environment\",\"optional\":true}", true)]
        public IEnvironment Environment
        {
            get;
            set;
        }

        [JsiiProperty("name", "{\"primitive\":\"string\"}", true)]
        public string Name
        {
            get;
            set;
        }
    }
}