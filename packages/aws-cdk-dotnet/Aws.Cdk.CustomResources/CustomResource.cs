using Aws.Cdk;
using Aws.Cdk.Resources.cloudformation;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Aws.Cdk.CustomResources
{
    /// <summary>
    /// Custom resource that is implemented using a Lambda
    /// 
    /// As a custom resource author, you should be publishing a subclass of this class
    /// that hides the choice of provider, and accepts a strongly-typed properties
    /// object with the properties your provider accepts.
    /// </summary>
    [JsiiClass("@aws-cdk/custom-resources", "jsii$_aws_cdk_custom_resources$.CustomResource", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_custom_resources$.CustomResourceProps\"}}]")]
    public class CustomResource : Aws.Cdk.Resources.cloudformation.CustomResource
    {
        public CustomResource(Construct parent, string name, ICustomResourceProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected CustomResource(ByRefValue reference): base(reference)
        {
        }

        protected CustomResource(DeputyProps props): base(props)
        {
        }

        /// <summary>Override renderProperties to mix in the user-defined properties</summary>
        [JsiiMethod("renderProperties", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}", "[]")]
        protected override IDictionary<string, object> RenderProperties()
        {
            return InvokeMethod<IDictionary<string, object>>(new object[]{});
        }
    }
}