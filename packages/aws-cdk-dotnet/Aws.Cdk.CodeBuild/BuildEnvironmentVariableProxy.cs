using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    [JsiiInterfaceProxy("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.BuildEnvironmentVariable")]
    public class BuildEnvironmentVariableProxy : DeputyBase, IBuildEnvironmentVariable
    {
        private BuildEnvironmentVariableProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The type of environment variable.</summary>
        /// <remarks>default: PlainText</remarks>
        [JsiiProperty("type", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Type
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The value of the environment variable (or the name of the parameter in
        /// the SSM parameter store.)
        /// </summary>
        [JsiiProperty("value", "{\"primitive\":\"any\"}")]
        public virtual object Value
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }
    }
}