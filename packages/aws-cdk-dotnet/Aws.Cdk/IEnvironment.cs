using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>The deployment environment for a stack.</summary>
    [JsiiInterface("@aws-cdk/core", "jsii$_aws_cdk_core$.Environment")]
    public interface IEnvironment
    {
        /// <summary>
        /// The AWS accopunt ID for this environment.
        /// If not specified, the context parameter `default-account` is used.
        /// </summary>
        [JsiiProperty("account", "{\"primitive\":\"string\",\"optional\":true}")]
        string Account
        {
            get;
            set;
        }

        /// <summary>
        /// The AWS region for this environment.
        /// If not specified, the context parameter `default-region` is used.
        /// </summary>
        [JsiiProperty("region", "{\"primitive\":\"string\",\"optional\":true}")]
        string Region
        {
            get;
            set;
        }
    }
}