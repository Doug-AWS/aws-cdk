using AWS.Cdk;
using AWS.Cdk.Resources.iam;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Iam
{
    [JsiiClass("@aws-cdk/iam", "jsii$_aws_cdk_iam$.Group", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.GroupProps\",\"optional\":true}}]")]
    public class Group : Construct, IIIdentityResource
    {
        public Group(Construct parent, string name, IGroupProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Group(ByRefValue reference): base(reference)
        {
        }

        protected Group(DeputyProps props): base(props)
        {
        }

        /// <summary>The runtime name of this group.</summary>
        [JsiiProperty("groupName", "{\"fqn\":\"jsii$_aws_cdk_iam$.GroupName\"}")]
        public virtual GroupName GroupName
        {
            get => GetProperty<GroupName>();
        }

        /// <summary>The ARN of this group.</summary>
        [JsiiProperty("groupArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.iam.GroupArn\"}")]
        public virtual GroupArn GroupArn
        {
            get => GetProperty<GroupArn>();
        }

        /// <summary>An "AWS" policy principal that represents this group.</summary>
        [JsiiProperty("principal", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyPrincipal\"}")]
        public virtual PolicyPrincipal Principal
        {
            get => GetProperty<PolicyPrincipal>();
        }

        /// <summary>Attaches a managed policy to this group.</summary>
        /// <param name = "arn">The ARN of the managed policy to attach.</param>
        [JsiiMethod("attachManagedPolicy", null, "[{\"name\":\"arn\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual void AttachManagedPolicy(object arn)
        {
            InvokeVoidMethod(new object[]{arn});
        }

        /// <summary>Attaches a policy to this group.</summary>
        /// <param name = "policy">The policy to attach.</param>
        [JsiiMethod("attachInlinePolicy", null, "[{\"name\":\"policy\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.Policy\"}}]")]
        public virtual void AttachInlinePolicy(Policy policy)
        {
            InvokeVoidMethod(new object[]{policy});
        }

        /// <summary>Adds a user to this group.</summary>
        [JsiiMethod("addUser", null, "[{\"name\":\"user\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.User\"}}]")]
        public virtual void AddUser(User user)
        {
            InvokeVoidMethod(new object[]{user});
        }

        /// <summary>Adds an IAM statement to the default policy.</summary>
        [JsiiMethod("addToPolicy", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddToPolicy(PolicyStatement statement)
        {
            InvokeVoidMethod(new object[]{statement});
        }
    }
}