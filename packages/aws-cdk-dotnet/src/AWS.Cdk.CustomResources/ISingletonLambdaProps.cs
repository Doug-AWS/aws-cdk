using AWS.Cdk.Lambda;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CustomResources
{
    /// <summary>Properties for a newly created singleton Lambda</summary>
    [JsiiInterface("@aws-cdk/custom-resources", "jsii$_aws_cdk_custom_resources$.SingletonLambdaProps")]
    public interface ISingletonLambdaProps : ILambdaProps
    {
        /// <summary>
        /// A unique identifier to identify this lambda
        /// 
        /// The identifier should be unique across all custom resource providers.
        /// We recommend generating a UUID per provider.
        /// </summary>
        [JsiiProperty("uuid", "{\"primitive\":\"string\"}")]
        string Uuid
        {
            get;
            set;
        }
    }
}