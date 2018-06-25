using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CxApi
{
    /// <summary>
    /// Represents a missing piece of context.
    /// (should have been an interface, but jsii still doesn't have support for structs).
    /// </summary>
    [JsiiInterface("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.MissingContext")]
    public interface IMissingContext
    {
        [JsiiProperty("provider", "{\"primitive\":\"string\"}")]
        string Provider
        {
            get;
            set;
        }

        [JsiiProperty("scope", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}")]
        string[] Scope
        {
            get;
            set;
        }

        [JsiiProperty("args", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}")]
        string[] Args
        {
            get;
            set;
        }
    }
}