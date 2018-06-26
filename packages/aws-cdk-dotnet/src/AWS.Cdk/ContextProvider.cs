using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    /// <summary>
    /// Base class for the model side of context providers
    /// 
    /// Instances of this class communicate with context provider plugins in the 'cdk
    /// toolkit' via context variables (input), outputting specialized queries for
    /// more context variables (output).
    /// 
    /// ContextProvider needs access to a Construct to hook into the context mechanism.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.ContextProvider", "[{\"name\":\"context\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}}]")]
    public class ContextProvider : DeputyBase
    {
        public ContextProvider(Construct context): base(new DeputyProps(new object[]{context}))
        {
        }

        protected ContextProvider(ByRefValue reference): base(reference)
        {
        }

        protected ContextProvider(DeputyProps props): base(props)
        {
        }

        /// <summary>Read a provider value, verifying it's a string</summary>
        [JsiiMethod("getStringValue", "{\"primitive\":\"string\"}", "[{\"name\":\"provider\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"scope\",\"type\":{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}},{\"name\":\"args\",\"type\":{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}}]")]
        public virtual string GetStringValue(string provider, string[] scope, string[] args)
        {
            return InvokeMethod<string>(new object[]{provider, scope, args});
        }

        /// <summary>Read a provider value, verifying it's a list</summary>
        [JsiiMethod("getStringListValue", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}", "[{\"name\":\"provider\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"scope\",\"type\":{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}},{\"name\":\"args\",\"type\":{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}},{\"name\":\"defaultValue\",\"type\":{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}},\"optional\":true}}]")]
        public virtual string[] GetStringListValue(string provider, string[] scope, string[] args, string[] defaultValue)
        {
            return InvokeMethod<string[]>(new object[]{provider, scope, args, defaultValue});
        }

        /// <summary>Helper function to wrap up account and region into a scope tuple</summary>
        [JsiiMethod("accountRegionScope", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}", "[{\"name\":\"providerDescription\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual string[] AccountRegionScope(string providerDescription)
        {
            return InvokeMethod<string[]>(new object[]{providerDescription});
        }
    }
}