using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;

namespace AWS.Cdk
{
    /// <summary>
    /// Includes a CloudFormation template into a stack. All elements of the template will be merged into
    /// the current stack, together with any elements created programmatically.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.Include", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.IncludeProps\"}}]")]
    public class Include : StackElement
    {
        public Include(Construct parent, string name, IIncludeProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Include(ByRefValue reference): base(reference)
        {
        }

        protected Include(DeputyProps props): base(props)
        {
        }

        /// <summary>The included template.</summary>
        [JsiiProperty("template", "{\"primitive\":\"json\"}")]
        public virtual JObject Template
        {
            get => GetProperty<JObject>();
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