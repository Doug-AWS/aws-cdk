using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CxApi
{
    /// <summary>An metadata entry in the construct.</summary>
    [JsiiInterface("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.MetadataEntry")]
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