using Aws.Cdk.Resources.ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    public class SecurityGroupRefProps : DeputyBase, ISecurityGroupRefProps
    {
        /// <summary>ID of security group</summary>
        [JsiiProperty("securityGroupId", "{\"fqn\":\"jsii$_aws_cdk_resources$.ec2.SecurityGroupId\"}", true)]
        public SecurityGroupId SecurityGroupId
        {
            get;
            set;
        }
    }
}