using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Lambda
{
    /// <summary>Properties for a new Lambda version</summary>
    [JsiiInterfaceProxy("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.VersionProps")]
    public class VersionPropsProxy : DeputyBase, IVersionProps
    {
        private VersionPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// SHA256 of the version of the Lambda source code
        /// 
        /// Specify to validate that you're deploying the right version.
        /// </summary>
        /// <remarks>default: No validation is performed</remarks>
        [JsiiProperty("codeSha256", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string CodeSha256
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Description of the version</summary>
        /// <remarks>default: Description of the Lambda</remarks>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Description
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Function to get the value of</summary>
        [JsiiProperty("lambda", "{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRef\"}")]
        public virtual LambdaRef Lambda
        {
            get => GetProperty<LambdaRef>();
            set => SetProperty(value);
        }
    }
}