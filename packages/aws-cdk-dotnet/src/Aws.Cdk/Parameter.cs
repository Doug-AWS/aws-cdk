using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;

namespace Aws.Cdk
{
    /// <summary>
    /// Use the optional Parameters section to customize your templates.
    /// Parameters enable you to input custom values to your template each time you create or
    /// update a stack.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.Parameter", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.ParameterProps\"}}]")]
    public class Parameter : Referenceable
    {
        public Parameter(Construct parent, string name, IParameterProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Parameter(ByRefValue reference): base(reference)
        {
        }

        protected Parameter(DeputyProps props): base(props)
        {
        }

        /// <summary>A token that represents the actual value of this parameter.</summary>
        [JsiiProperty("value", "{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}")]
        public virtual Token Value
        {
            get => GetProperty<Token>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Returns the CloudFormation 'snippet' for this entity. The snippet will only be merged
        /// at the root level to ensure there are no identity conflicts.
        /// 
        /// For example, a Resource class will return something like:
        /// {
        ///      Resources: {
        ///          [this.logicalId]: {
        ///              Type: this.resourceType,
        ///              Properties: this.props,
        ///              Condition: this.condition
        ///          }
        ///      }
        /// }
        /// </summary>
        [JsiiMethod("toCloudFormation", "{\"primitive\":\"json\"}", "[]")]
        public override JObject ToCloudFormation()
        {
            return InvokeMethod<JObject>(new object[]{});
        }

        /// <summary>
        /// Allows using parameters as tokens without the need to dereference them.
        /// This implicitly implements Token, until we make it an interface.
        /// </summary>
        [JsiiMethod("resolve", "{\"primitive\":\"any\"}", "[]")]
        public virtual object Resolve()
        {
            return InvokeMethod<object>(new object[]{});
        }
    }
}