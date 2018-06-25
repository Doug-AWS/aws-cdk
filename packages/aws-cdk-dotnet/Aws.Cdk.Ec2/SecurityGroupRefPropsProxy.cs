using Aws.Cdk.Resources.ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.SecurityGroupRefProps")]
    public class SecurityGroupRefPropsProxy : DeputyBase, ISecurityGroupRefProps
    {
        private SecurityGroupRefPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>ID of security group</summary>
        [JsiiProperty("securityGroupId", "{\"fqn\":\"jsii$_aws_cdk_resources$.ec2.SecurityGroupId\"}")]
        public virtual SecurityGroupId SecurityGroupId
        {
            get => GetProperty<SecurityGroupId>();
            set => SetProperty(value);
        }
    }
}