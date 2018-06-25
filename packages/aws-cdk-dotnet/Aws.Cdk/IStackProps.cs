using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    [JsiiInterface("@aws-cdk/core", "jsii$_aws_cdk_core$.StackProps")]
    public interface IStackProps
    {
        /// <summary>
        /// The AWS environment (account/region) where this stack will be deployed.
        /// 
        /// If not supplied, the `default-account` and `default-region` context parameters will be
        /// used. If they are undefined, it will not be possible to deploy the stack.
        /// </summary>
        [JsiiProperty("env", "{\"fqn\":\"jsii$_aws_cdk_core$.Environment\",\"optional\":true}")]
        IEnvironment Env
        {
            get;
            set;
        }

        /// <summary>
        /// Strategy for logical ID generation
        /// 
        /// Optional. If not supplied, the HashedNamingScheme will be used.
        /// </summary>
        [JsiiProperty("namingScheme", "{\"fqn\":\"jsii$_aws_cdk_core$.IAddressingScheme\",\"optional\":true}")]
        IIAddressingScheme NamingScheme
        {
            get;
            set;
        }
    }
}