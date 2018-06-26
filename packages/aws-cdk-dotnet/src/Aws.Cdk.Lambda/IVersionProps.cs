using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Lambda
{
    /// <summary>Properties for a new Lambda version</summary>
    [JsiiInterface("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.VersionProps")]
    public interface IVersionProps
    {
        /// <summary>
        /// SHA256 of the version of the Lambda source code
        /// 
        /// Specify to validate that you're deploying the right version.
        /// </summary>
        /// <remarks>default: No validation is performed</remarks>
        [JsiiProperty("codeSha256", "{\"primitive\":\"string\",\"optional\":true}")]
        string CodeSha256
        {
            get;
            set;
        }

        /// <summary>Description of the version</summary>
        /// <remarks>default: Description of the Lambda</remarks>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        string Description
        {
            get;
            set;
        }

        /// <summary>Function to get the value of</summary>
        [JsiiProperty("lambda", "{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRef\"}")]
        LambdaRef Lambda
        {
            get;
            set;
        }
    }
}