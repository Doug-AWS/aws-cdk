using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Iam
{
    [JsiiInterfaceProxy("@aws-cdk/iam", "jsii$_aws_cdk_iam$.PolicyProps")]
    public class PolicyPropsProxy : DeputyBase, IPolicyProps
    {
        private PolicyPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The name of the policy. If you specify multiple policies for an entity,
        /// specify unique names. For example, if you specify a list of policies for
        /// an IAM role, each policy must have a unique name.
        /// </summary>
        /// <remarks>
        /// default: Uses the logical ID of the policy resource, which is ensured to
        /// be unique within the stack.
        /// </remarks>
        [JsiiProperty("policyName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string PolicyName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Users to attach this policy to.
        /// You can also use `attachToUser(user)` to attach this policy to a user.
        /// </summary>
        [JsiiProperty("users", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_iam$.User\"}},\"optional\":true}")]
        public virtual User[] Users
        {
            get => GetProperty<User[]>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Roles to attach this policy to.
        /// You can also use `attachToRole(role)` to attach this policy to a role.
        /// </summary>
        [JsiiProperty("roles", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_iam$.Role\"}},\"optional\":true}")]
        public virtual Role[] Roles
        {
            get => GetProperty<Role[]>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Groups to attach this policy to.
        /// You can also use `attachToGroup(group)` to attach this policy to a group.
        /// </summary>
        [JsiiProperty("groups", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_iam$.Group\"}},\"optional\":true}")]
        public virtual Group[] Groups
        {
            get => GetProperty<Group[]>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Initial set of permissions to add to this policy document.
        /// You can also use `addPermission(statement)` to add permissions later.
        /// </summary>
        [JsiiProperty("statements", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}},\"optional\":true}")]
        public virtual PolicyStatement[] Statements
        {
            get => GetProperty<PolicyStatement[]>();
            set => SetProperty(value);
        }
    }
}