using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>An metadata entry in the construct.</summary>
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.MetadataEntry")]
    public class MetadataEntryProxy : DeputyBase, IMetadataEntry
    {
        private MetadataEntryProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The type of the metadata entry.</summary>
        [JsiiProperty("type", "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The data.</summary>
        [JsiiProperty("data", "{\"primitive\":\"any\",\"optional\":true}")]
        public virtual object Data
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }

        /// <summary>A stack trace for when the entry was created.</summary>
        [JsiiProperty("trace", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}")]
        public virtual string[] Trace
        {
            get => GetProperty<string[]>();
            set => SetProperty(value);
        }
    }
}