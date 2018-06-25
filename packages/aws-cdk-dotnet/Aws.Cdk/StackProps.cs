using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    public class StackProps : DeputyBase, IStackProps
    {
        /// <summary>
        /// The AWS environment (account/region) where this stack will be deployed.
        /// 
        /// If not supplied, the `default-account` and `default-region` context parameters will be
        /// used. If they are undefined, it will not be possible to deploy the stack.
        /// </summary>
        [JsiiProperty("env", "{\"fqn\":\"jsii$_aws_cdk_core$.Environment\",\"optional\":true}", true)]
        public IEnvironment Env
        {
            get;
            set;
        }

        /// <summary>
        /// Strategy for logical ID generation
        /// 
        /// Optional. If not supplied, the HashedNamingScheme will be used.
        /// </summary>
        [JsiiProperty("namingScheme", "{\"fqn\":\"jsii$_aws_cdk_core$.IAddressingScheme\",\"optional\":true}", true)]
        public IIAddressingScheme NamingScheme
        {
            get;
            set;
        }
    }
}