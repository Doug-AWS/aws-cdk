using AWS.Cdk;
using AWS.Cdk.Resources.iam;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Iam
{
    /// <summary>
    /// IAM Role
    /// 
    /// Defines an IAM role. The role is created with an assume policy document associated with
    /// the specified AWS service principal defined in `serviceAssumeRole`.
    /// </summary>
    [JsiiClass("@aws-cdk/iam", "jsii$_aws_cdk_iam$.Role", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.RoleProps\"}}]")]
    public class Role : Construct, IIIdentityResource, IIDependable
    {
        public Role(Construct parent, string name, IRoleProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Role(ByRefValue reference): base(reference)
        {
        }

        protected Role(DeputyProps props): base(props)
        {
        }

        /// <summary>The assume role policy document associated with this role.</summary>
        [JsiiProperty("assumeRolePolicy", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyDocument\",\"optional\":true}")]
        public virtual PolicyDocument AssumeRolePolicy
        {
            get => GetProperty<PolicyDocument>();
        }

        /// <summary>Returns the ARN of this role.</summary>
        [JsiiProperty("roleArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.iam.RoleArn\"}")]
        public virtual RoleArn RoleArn
        {
            get => GetProperty<RoleArn>();
        }

        /// <summary>Returns the name of the role.</summary>
        [JsiiProperty("roleName", "{\"fqn\":\"jsii$_aws_cdk_iam$.RoleName\"}")]
        public virtual RoleName RoleName
        {
            get => GetProperty<RoleName>();
        }

        /// <summary>Returns the ARN of this role.</summary>
        [JsiiProperty("principal", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyPrincipal\"}")]
        public virtual PolicyPrincipal Principal
        {
            get => GetProperty<PolicyPrincipal>();
        }

        /// <summary>Returns the role.</summary>
        [JsiiProperty("dependencyElements", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_core$.IDependable\"}}}")]
        public virtual IIDependable[] DependencyElements
        {
            get => GetProperty<IIDependable[]>();
        }

        /// <summary>
        /// Adds a permission to the role's default policy document.
        /// If there is no default policy attached to this role, it will be created.
        /// </summary>
        [JsiiMethod("addToPolicy", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddToPolicy(PolicyStatement statement)
        {
            InvokeVoidMethod(new object[]{statement});
        }

        /// <summary>Attaches a managed policy to this role.</summary>
        /// <param name = "arn">The ARN of the managed policy to attach.</param>
        [JsiiMethod("attachManagedPolicy", null, "[{\"name\":\"arn\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual void AttachManagedPolicy(object arn)
        {
            InvokeVoidMethod(new object[]{arn});
        }

        /// <summary>Attaches a policy to this role.</summary>
        /// <param name = "policy">The policy to attach</param>
        [JsiiMethod("attachInlinePolicy", null, "[{\"name\":\"policy\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.Policy\"}}]")]
        public virtual void AttachInlinePolicy(Policy policy)
        {
            InvokeVoidMethod(new object[]{policy});
        }
    }
}