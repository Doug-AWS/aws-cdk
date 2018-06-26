using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Iam
{
    [JsiiInterface("@aws-cdk/iam", "jsii$_aws_cdk_iam$.IIdentityResource")]
    public interface IIIdentityResource
    {
        /// <summary>The IAM principal of this identity (i.e. AWS principal, service principal, etc).</summary>
        [JsiiProperty("principal", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyPrincipal\"}")]
        PolicyPrincipal Principal
        {
            get;
        }

        /// <summary>
        /// Adds an IAM statement to the default inline policy associated with this
        /// principal. If a policy doesn't exist, it is created.
        /// </summary>
        [JsiiMethod("addToPolicy", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        void AddToPolicy(PolicyStatement statement);
        /// <summary>
        /// Attaches an inline policy to this principal.
        /// This is the same as calling `policy.addToXxx(principal)`.
        /// </summary>
        /// <param name = "policy">The policy resource to attach to this principal.</param>
        [JsiiMethod("attachInlinePolicy", null, "[{\"name\":\"policy\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.Policy\"}}]")]
        void AttachInlinePolicy(Policy policy);
        /// <summary>Attaches a managed policy to this principal.</summary>
        /// <param name = "arn">The ARN of the managed policy</param>
        [JsiiMethod("attachManagedPolicy", null, "[{\"name\":\"arn\",\"type\":{\"primitive\":\"any\"}}]")]
        void AttachManagedPolicy(object arn);
    }
}