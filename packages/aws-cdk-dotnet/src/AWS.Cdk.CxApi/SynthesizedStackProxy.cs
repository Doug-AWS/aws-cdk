using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace AWS.Cdk.CxApi
{
    /// <summary>A complete synthesized stack</summary>
    [JsiiInterfaceProxy("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.SynthesizedStack")]
    public class SynthesizedStackProxy : DeputyBase, ISynthesizedStack
    {
        private SynthesizedStackProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("missing", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.MissingContext\"}},\"optional\":true}")]
        public virtual IDictionary<string, IMissingContext> Missing
        {
            get => GetProperty<IDictionary<string, IMissingContext>>();
            set => SetProperty(value);
        }

        [JsiiProperty("metadata", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.MetadataEntry\"}}}}}")]
        public virtual IDictionary<string, IMetadataEntry[]> Metadata
        {
            get => GetProperty<IDictionary<string, IMetadataEntry[]>>();
            set => SetProperty(value);
        }

        [JsiiProperty("template", "{\"primitive\":\"any\"}")]
        public virtual object Template
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }

        [JsiiProperty("environment", "{\"fqn\":\"jsii$_aws_cdk_cx_api$.Environment\",\"optional\":true}")]
        public virtual IEnvironment Environment
        {
            get => GetProperty<IEnvironment>();
            set => SetProperty(value);
        }

        [JsiiProperty("name", "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}