using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    /// <summary>The deployment environment for a stack.</summary>
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.Environment")]
    public class EnvironmentProxy : DeputyBase, IEnvironment
    {
        private EnvironmentProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The AWS accopunt ID for this environment.
        /// If not specified, the context parameter `default-account` is used.
        /// </summary>
        [JsiiProperty("account", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Account
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The AWS region for this environment.
        /// If not specified, the context parameter `default-region` is used.
        /// </summary>
        [JsiiProperty("region", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Region
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}