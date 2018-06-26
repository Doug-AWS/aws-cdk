using AWS.Cdk.CxApi;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace AWS.Cdk
{
    /// <summary>A root construct which represents a single CloudFormation stack.</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.Stack", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.App\",\"optional\":true}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\",\"optional\":true}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.StackProps\",\"optional\":true}}]")]
    public class Stack : Construct
    {
        public Stack(App parent, string name, IStackProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Stack(ByRefValue reference): base(reference)
        {
        }

        protected Stack(DeputyProps props): base(props)
        {
        }

        /// <summary>
        /// Lists all missing contextual information.
        /// This is returned when the stack is synthesized under the 'missing' attribute
        /// and allows tooling to obtain the context and re-synthesize.
        /// </summary>
        [JsiiProperty("missingContext", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.MissingContext\"}}}")]
        public virtual IDictionary<string, IMissingContext> MissingContext
        {
            get => GetProperty<IDictionary<string, IMissingContext>>();
        }

        /// <summary>The environment in which this stack is deployed.</summary>
        [JsiiProperty("env", "{\"fqn\":\"jsii$_aws_cdk_core$.Environment\"}")]
        public virtual IEnvironment Env
        {
            get => GetProperty<IEnvironment>();
        }

        /// <summary>Used to determine if this construct is a stack.</summary>
        [JsiiProperty("isStack", "{\"primitive\":\"boolean\"}")]
        public virtual bool IsStack
        {
            get => GetProperty<bool>();
        }

        /// <summary>Logical ID generation strategy</summary>
        [JsiiProperty("logicalIds", "{\"fqn\":\"jsii$_aws_cdk_core$.LogicalIDs\"}")]
        public virtual LogicalIDs LogicalIds
        {
            get => GetProperty<LogicalIDs>();
        }

        /// <summary>Options for CloudFormation template (like version, transform, description).</summary>
        [JsiiProperty("templateOptions", "{\"fqn\":\"jsii$_aws_cdk_core$.TemplateOptions\"}")]
        public virtual ITemplateOptions TemplateOptions
        {
            get => GetProperty<ITemplateOptions>();
        }

        /// <summary>Traverses the tree and looks up for the Stack root.</summary>
        /// <param name = "node">A construct in the tree</param>
        /// <returns>The Stack object (throws if the node is not part of a Stack-rooted tree)</returns>
        [JsiiMethod("find", "{\"fqn\":\"jsii$_aws_cdk_core$.Stack\"}", "[{\"name\":\"node\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}}]")]
        public virtual Stack Find(Construct node)
        {
            return InvokeMethod<Stack>(new object[]{node});
        }

        /// <summary>
        /// Adds a metadata annotation "aws:cdk:physical-name" to the construct if physicalName
        /// is non-null. This can be used later by tools and aspects to determine if resources
        /// have been created with physical names.
        /// </summary>
        [JsiiMethod("annotatePhysicalName", null, "[{\"name\":\"construct\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"physicalName\",\"type\":{\"primitive\":\"string\",\"optional\":true}}]")]
        public virtual void AnnotatePhysicalName(Construct construct, string physicalName)
        {
            InvokeVoidMethod(new object[]{construct, physicalName});
        }

        /// <summary>Looks up a resource by path.</summary>
        /// <returns>The Resource or undefined if not found</returns>
        [JsiiMethod("findResource", "{\"fqn\":\"jsii$_aws_cdk_core$.Resource\",\"optional\":true}", "[{\"name\":\"path\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual Resource FindResource(string path)
        {
            return InvokeMethod<Resource>(new object[]{path});
        }

        /// <summary>
        /// Returns the CloudFormation template for this stack by traversing
        /// the tree and invoking toCloudFormation() on all Entity objects.
        /// </summary>
        [JsiiMethod("toCloudFormation", "{\"primitive\":\"any\"}", "[]")]
        public virtual object ToCloudFormation()
        {
            return InvokeMethod<object>(new object[]{});
        }

        /// <param name = "why">more information about why region is required.</param>
        /// <returns>The region in which this stack is deployed. Throws if region is not defined.</returns>
        [JsiiMethod("requireRegion", "{\"primitive\":\"string\"}", "[{\"name\":\"why\",\"type\":{\"primitive\":\"string\",\"optional\":true}}]")]
        public virtual string RequireRegion(string why)
        {
            return InvokeMethod<string>(new object[]{why});
        }

        /// <summary>
        /// Indicate that a context key was expected
        /// 
        /// Contains instructions on how the key should be supplied.
        /// </summary>
        /// <param name = "key">Key that uniquely identifies this missing context.</param>
        /// <param name = "details">The set of parameters needed to obtain the context (specific to context provider).</param>
        [JsiiMethod("reportMissingContext", null, "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"details\",\"type\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.MissingContext\"}}]")]
        public virtual void ReportMissingContext(string key, IMissingContext details)
        {
            InvokeVoidMethod(new object[]{key, details});
        }

        /// <summary>Rename a generated logical identities</summary>
        [JsiiMethod("renameLogical", null, "[{\"name\":\"oldId\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"newId\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual void RenameLogical(string oldId, string newId)
        {
            InvokeVoidMethod(new object[]{oldId, newId});
        }
    }
}