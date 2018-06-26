using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CxApi
{
    /// <summary>Identifies and contains metadata about a stack</summary>
    [JsiiInterface("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.StackInfo")]
    public interface IStackInfo : IStackId
    {
        [JsiiProperty("environment", "{\"fqn\":\"jsii$_aws_cdk_cx_api$.Environment\",\"optional\":true}")]
        IEnvironment Environment
        {
            get;
            set;
        }
    }
}