using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CxApi
{
    /// <summary>Identifies and contains metadata about a stack</summary>
    [JsiiInterfaceProxy("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.StackInfo")]
    public class StackInfoProxy : DeputyBase, IStackInfo
    {
        private StackInfoProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("environment", "{\"fqn\":\"jsii$_aws_cdk_cx_api$.Environment\",\"optional\":true}")]
        public virtual IEnvironment Environment
        {
            get => GetProperty<IEnvironment>();
            set => SetProperty(value);
        }

        [JsiiProperty("name", "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}