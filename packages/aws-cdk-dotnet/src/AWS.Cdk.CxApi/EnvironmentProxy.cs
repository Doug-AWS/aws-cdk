using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CxApi
{
    /// <summary>Models an AWS execution environment, for use within the CDK toolkit.</summary>
    [JsiiInterfaceProxy("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.Environment")]
    public class EnvironmentProxy : DeputyBase, IEnvironment
    {
        private EnvironmentProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The arbitrary name of this environment (user-set, or at least user-meaningful) </summary>
        [JsiiProperty("name", "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The 12-digit AWS account ID for the account this environment deploys into </summary>
        [JsiiProperty("account", "{\"primitive\":\"string\"}")]
        public virtual string Account
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The AWS region name where this environment deploys into </summary>
        [JsiiProperty("region", "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}