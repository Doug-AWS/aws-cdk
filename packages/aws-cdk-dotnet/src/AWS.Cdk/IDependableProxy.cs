using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    /// <summary>Represents a construct that can be "depended on" via `addDependency`.</summary>
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.IDependable")]
    public class IDependableProxy : DeputyBase, IIDependable
    {
        private IDependableProxy(ByRefValue reference): base(reference)
        {
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
    }
}