using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CxApi
{
    /// <summary>
    /// Represents a missing piece of context.
    /// (should have been an interface, but jsii still doesn't have support for structs).
    /// </summary>
    [JsiiInterfaceProxy("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.MissingContext")]
    public class MissingContextProxy : DeputyBase, IMissingContext
    {
        private MissingContextProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("provider", "{\"primitive\":\"string\"}")]
        public virtual string Provider
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("scope", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}")]
        public virtual string[] Scope
        {
            get => GetProperty<string[]>();
            set => SetProperty(value);
        }

        [JsiiProperty("args", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}")]
        public virtual string[] Args
        {
            get => GetProperty<string[]>();
            set => SetProperty(value);
        }
    }
}