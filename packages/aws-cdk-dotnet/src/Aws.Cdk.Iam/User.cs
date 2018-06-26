using Aws.Cdk;
using Aws.Cdk.Resources.iam;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Iam
{
    [JsiiClass("@aws-cdk/iam", "jsii$_aws_cdk_iam$.User", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.UserProps\",\"optional\":true}}]")]
    public class User : Construct, IIIdentityResource
    {
        public User(Construct parent, string name, IUserProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected User(ByRefValue reference): base(reference)
        {
        }

        protected User(DeputyProps props): base(props)
        {
        }

        /// <summary>An attribute that represents the user name.</summary>
        [JsiiProperty("userName", "{\"fqn\":\"jsii$_aws_cdk_iam$.UserName\"}")]
        public virtual UserName UserName
        {
            get => GetProperty<UserName>();
        }

        /// <summary>An attribute that represents the user's ARN.</summary>
        [JsiiProperty("userArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.iam.UserArn\"}")]
        public virtual UserArn UserArn
        {
            get => GetProperty<UserArn>();
        }

        /// <summary>Returns the ARN of this user.</summary>
        [JsiiProperty("principal", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyPrincipal\"}")]
        public virtual PolicyPrincipal Principal
        {
            get => GetProperty<PolicyPrincipal>();
        }

        /// <summary>Adds this user to a group.</summary>
        [JsiiMethod("addToGroup", null, "[{\"name\":\"group\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.Group\"}}]")]
        public virtual void AddToGroup(Group group)
        {
            InvokeVoidMethod(new object[]{group});
        }

        /// <summary>Attaches a managed policy to the user.</summary>
        /// <param name = "arn">The ARN of the managed policy to attach.</param>
        [JsiiMethod("attachManagedPolicy", null, "[{\"name\":\"arn\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual void AttachManagedPolicy(object arn)
        {
            InvokeVoidMethod(new object[]{arn});
        }

        /// <summary>Attaches a policy to this user.</summary>
        [JsiiMethod("attachInlinePolicy", null, "[{\"name\":\"policy\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.Policy\"}}]")]
        public virtual void AttachInlinePolicy(Policy policy)
        {
            InvokeVoidMethod(new object[]{policy});
        }

        /// <summary>Adds an IAM statement to the default policy.</summary>
        [JsiiMethod("addToPolicy", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddToPolicy(PolicyStatement statement)
        {
            InvokeVoidMethod(new object[]{statement});
        }
    }
}