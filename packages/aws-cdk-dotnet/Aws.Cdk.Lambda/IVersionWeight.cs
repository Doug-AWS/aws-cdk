using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Lambda
{
    /// <summary>A version/weight pair for routing traffic to Lambda functions</summary>
    [JsiiInterface("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.VersionWeight")]
    public interface IVersionWeight
    {
        /// <summary>The version to route traffic to</summary>
        [JsiiProperty("version", "{\"fqn\":\"jsii$_aws_cdk_lambda$.Version\"}")]
        Version Version
        {
            get;
        }

        /// <summary>How much weight to assign to this version (0..1)</summary>
        [JsiiProperty("weight", "{\"primitive\":\"number\"}")]
        double Weight
        {
            get;
        }
    }
}