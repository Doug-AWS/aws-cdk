using Aws.Cdk.Resources.ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    [JsiiInterface("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.SecurityGroupRefProps")]
    public interface ISecurityGroupRefProps
    {
        /// <summary>ID of security group</summary>
        [JsiiProperty("securityGroupId", "{\"fqn\":\"jsii$_aws_cdk_resources$.ec2.SecurityGroupId\"}")]
        SecurityGroupId SecurityGroupId
        {
            get;
            set;
        }
    }
}