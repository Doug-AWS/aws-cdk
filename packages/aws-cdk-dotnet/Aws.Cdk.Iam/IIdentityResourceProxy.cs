using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Iam
{
    [JsiiInterfaceProxy("@aws-cdk/iam", "jsii$_aws_cdk_iam$.IIdentityResource")]
    public class IIdentityResourceProxy : DeputyBase, IIIdentityResource
    {
        private IIdentityResourceProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The IAM principal of this identity (i.e. AWS principal, service principal, etc).</summary>
        [JsiiProperty("principal", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyPrincipal\"}")]
        public virtual PolicyPrincipal Principal
        {
            get => GetProperty<PolicyPrincipal>();
        }

        /// <summary>
        /// Adds an IAM statement to the default inline policy associated with this
        /// principal. If a policy doesn't exist, it is created.
        /// </summary>
        [JsiiMethod("addToPolicy", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddToPolicy(PolicyStatement statement)
        {
            InvokeVoidMethod(new object[]{statement});
        }

        /// <summary>
        /// Attaches an inline policy to this principal.
        /// This is the same as calling `policy.addToXxx(principal)`.
        /// </summary>
        /// <param name = "policy">The policy resource to attach to this principal.</param>
        [JsiiMethod("attachInlinePolicy", null, "[{\"name\":\"policy\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.Policy\"}}]")]
        public virtual void AttachInlinePolicy(Policy policy)
        {
            InvokeVoidMethod(new object[]{policy});
        }

        /// <summary>Attaches a managed policy to this principal.</summary>
        /// <param name = "arn">The ARN of the managed policy</param>
        [JsiiMethod("attachManagedPolicy", null, "[{\"name\":\"arn\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual void AttachManagedPolicy(object arn)
        {
            InvokeVoidMethod(new object[]{arn});
        }
    }
}