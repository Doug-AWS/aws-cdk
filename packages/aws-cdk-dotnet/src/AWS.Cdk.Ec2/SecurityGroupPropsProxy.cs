using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.SecurityGroupProps")]
    public class SecurityGroupPropsProxy : DeputyBase, ISecurityGroupProps
    {
        private SecurityGroupPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The name of the security group. For valid values, see the GroupName
        /// parameter of the CreateSecurityGroup action in the Amazon EC2 API
        /// Reference.
        /// 
        /// It is not recommended to use an explicit group name.
        /// </summary>
        /// <remarks>
        /// default: If you don't specify a GroupName, AWS CloudFormation generates a
        /// unique physical ID and uses that ID for the group name.
        /// </remarks>
        [JsiiProperty("groupName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string GroupName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>A description of the security group.</summary>
        /// <remarks>default: The default name will be the construct's CDK path.</remarks>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Description
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The VPC in which to create the security group.</summary>
        [JsiiProperty("vpc", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}")]
        public virtual VpcNetworkRef Vpc
        {
            get => GetProperty<VpcNetworkRef>();
            set => SetProperty(value);
        }
    }
}