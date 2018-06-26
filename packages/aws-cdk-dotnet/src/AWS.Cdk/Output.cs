using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;

namespace AWS.Cdk
{
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.Output", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.OutputProps\",\"optional\":true}}]")]
    public class Output : StackElement
    {
        public Output(Construct parent, string name, IOutputProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Output(ByRefValue reference): base(reference)
        {
        }

        protected Output(DeputyProps props): base(props)
        {
        }

        /// <summary>
        /// A String type that describes the output value.
        /// The description can be a maximum of 4 K in length.
        /// </summary>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Description
        {
            get => GetProperty<string>();
        }

        /// <summary>
        /// The value of the property returned by the aws cloudformation describe-stacks command.
        /// The value of an output can include literals, parameter references, pseudo-parameters,
        /// a mapping value, or intrinsic functions.
        /// </summary>
        [JsiiProperty("value", "{\"primitive\":\"any\",\"optional\":true}")]
        public virtual object Value
        {
            get => GetProperty<object>();
        }

        /// <summary>
        /// The name of the resource output to be exported for a cross-stack reference.
        /// By default, the logical ID of the Output element is used as it's export name.
        /// </summary>
        [JsiiProperty("export", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Export
        {
            get => GetProperty<string>();
        }

        /// <summary>
        /// A condition from the "Conditions" section to associate with this output
        /// value. If the condition evaluates to `false`, this output value will not
        /// be included in the stack.
        /// </summary>
        [JsiiProperty("condition", "{\"fqn\":\"jsii$_aws_cdk_core$.Condition\",\"optional\":true}")]
        public virtual Condition Condition
        {
            get => GetProperty<Condition>();
        }

        [JsiiProperty("ref", "{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}")]
        public virtual Token Ref
        {
            get => GetProperty<Token>();
        }

        /// <summary>Returns an FnImportValue bound to this export name.</summary>
        [JsiiMethod("makeImportValue", "{\"fqn\":\"jsii$_aws_cdk_core$.FnImportValue\"}", "[]")]
        public virtual FnImportValue MakeImportValue()
        {
            return InvokeMethod<FnImportValue>(new object[]{});
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
    }
}