using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodeBuild
{
    [JsiiInterface("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.BuildEnvironmentVariable")]
    public interface IBuildEnvironmentVariable
    {
        /// <summary>The type of environment variable.</summary>
        /// <remarks>default: PlainText</remarks>
        [JsiiProperty("type", "{\"primitive\":\"string\",\"optional\":true}")]
        string Type
        {
            get;
            set;
        }

        /// <summary>
        /// The value of the environment variable (or the name of the parameter in
        /// the SSM parameter store.)
        /// </summary>
        [JsiiProperty("value", "{\"primitive\":\"any\"}")]
        object Value
        {
            get;
            set;
        }
    }
}