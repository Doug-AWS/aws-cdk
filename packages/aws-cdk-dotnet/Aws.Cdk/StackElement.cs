using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;

namespace Aws.Cdk
{
    /// <summary>An element of a CloudFormation stack.</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.StackElement", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class StackElement : Construct, IIDependable
    {
        protected StackElement(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected StackElement(ByRefValue reference): base(reference)
        {
        }

        protected StackElement(DeputyProps props): base(props)
        {
        }

        /// <summary>The logical ID for this CloudFormation stack element</summary>
        [JsiiProperty("logicalId", "{\"primitive\":\"string\"}")]
        public virtual string LogicalId
        {
            get => GetProperty<string>();
        }

        /// <summary>The stack this Construct has been made a part of</summary>
        [JsiiProperty("stack", "{\"fqn\":\"jsii$_aws_cdk_core$.Stack\"}")]
        protected virtual Stack Stack
        {
            get => GetProperty<Stack>();
            set => SetProperty(value);
        }

        /// <returns>
        /// the stack trace of the point where this Resource was created from, sourced
        /// from the +metadata+ entry typed +aws:cdk:logicalId+, and with the bottom-most
        /// node +internal+ entries filtered.
        /// </returns>
        [JsiiProperty("creationStackTrace", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}")]
        public virtual string[] CreationStackTrace
        {
            get => GetProperty<string[]>();
        }

        /// <summary>Return the path with respect to the stack</summary>
        [JsiiProperty("stackPath", "{\"primitive\":\"string\"}")]
        public virtual string StackPath
        {
            get => GetProperty<string>();
        }

        /// <summary>
        /// Returns the set of all stack elements (resources, parameters, conditions)
        /// that should be added when a resource "depends on" this construct.
        /// </summary>
        [JsiiProperty("dependencyElements", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_core$.IDependable\"}}}")]
        public virtual IIDependable[] DependencyElements
        {
            get => GetProperty<IIDependable[]>();
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
        public abstract JObject ToCloudFormation();
    }
}