using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;

namespace AWS.Cdk
{
    /// <summary>
    /// Represents a CloudFormation condition, for resources which must be conditionally created and
    /// the determination must be made at deploy time.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.Condition", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.ConditionProps\",\"optional\":true}}]")]
    public class Condition : Referenceable
    {
        public Condition(Construct parent, string name, IConditionProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Condition(ByRefValue reference): base(reference)
        {
        }

        protected Condition(DeputyProps props): base(props)
        {
        }

        /// <summary>The condition statement.</summary>
        [JsiiProperty("expression", "{\"fqn\":\"jsii$_aws_cdk_core$.FnCondition\",\"optional\":true}")]
        public virtual FnCondition Expression
        {
            get => GetProperty<FnCondition>();
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
    }
}