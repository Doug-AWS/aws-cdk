using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>An metadata entry in the construct.</summary>
    [JsiiInterface("@aws-cdk/core", "jsii$_aws_cdk_core$.MetadataEntry")]
    public interface IMetadataEntry
    {
        /// <summary>The type of the metadata entry.</summary>
        [JsiiProperty("type", "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
            set;
        }

        /// <summary>The data.</summary>
        [JsiiProperty("data", "{\"primitive\":\"any\",\"optional\":true}")]
        object Data
        {
            get;
            set;
        }

        /// <summary>A stack trace for when the entry was created.</summary>
        [JsiiProperty("trace", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}")]
        string[] Trace
        {
            get;
            set;
        }
    }
}