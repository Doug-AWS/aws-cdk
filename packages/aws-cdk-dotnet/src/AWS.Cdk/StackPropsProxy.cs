using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.StackProps")]
    public class StackPropsProxy : DeputyBase, IStackProps
    {
        private StackPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The AWS environment (account/region) where this stack will be deployed.
        /// 
        /// If not supplied, the `default-account` and `default-region` context parameters will be
        /// used. If they are undefined, it will not be possible to deploy the stack.
        /// </summary>
        [JsiiProperty("env", "{\"fqn\":\"jsii$_aws_cdk_core$.Environment\",\"optional\":true}")]
        public virtual IEnvironment Env
        {
            get => GetProperty<IEnvironment>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Strategy for logical ID generation
        /// 
        /// Optional. If not supplied, the HashedNamingScheme will be used.
        /// </summary>
        [JsiiProperty("namingScheme", "{\"fqn\":\"jsii$_aws_cdk_core$.IAddressingScheme\",\"optional\":true}")]
        public virtual IIAddressingScheme NamingScheme
        {
            get => GetProperty<IIAddressingScheme>();
            set => SetProperty(value);
        }
    }
}