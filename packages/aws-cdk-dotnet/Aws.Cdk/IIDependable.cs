using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>Represents a construct that can be "depended on" via `addDependency`.</summary>
    [JsiiInterface("@aws-cdk/core", "jsii$_aws_cdk_core$.IDependable")]
    public interface IIDependable
    {
        /// <summary>
        /// Returns the set of all stack elements (resources, parameters, conditions)
        /// that should be added when a resource "depends on" this construct.
        /// </summary>
        [JsiiProperty("dependencyElements", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_core$.IDependable\"}}}")]
        IIDependable[] DependencyElements
        {
            get;
        }
    }
}