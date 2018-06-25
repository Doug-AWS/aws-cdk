using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// An output for a list of strings.
    /// 
    /// Exports a list of Tokens via an Output variable, and return a list of Tokens
    /// that selects the imported values for them.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.StringListOutput", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.StringListOutputProps\"}}]")]
    public class StringListOutput : Construct
    {
        public StringListOutput(Construct parent, string name, IStringListOutputProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected StringListOutput(ByRefValue reference): base(reference)
        {
        }

        protected StringListOutput(DeputyProps props): base(props)
        {
        }

        /// <summary>Number of elements in the stringlist</summary>
        [JsiiProperty("length", "{\"primitive\":\"number\"}")]
        public virtual double Length
        {
            get => GetProperty<double>();
        }

        /// <summary>Return an array of imported values for this Output</summary>
        [JsiiMethod("makeImportValues", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}}}", "[]")]
        public virtual Token[] MakeImportValues()
        {
            return InvokeMethod<Token[]>(new object[]{});
        }
    }
}