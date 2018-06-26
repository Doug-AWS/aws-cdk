using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Lambda
{
    /// <summary>
    /// Represents a permission statement that can be added to a Lambda's resource policy
    /// via the `addToResourcePolicy` method.
    /// </summary>
    [JsiiInterfaceProxy("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.LambdaPermission")]
    public class LambdaPermissionProxy : DeputyBase, ILambdaPermission
    {
        private LambdaPermissionProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The Lambda actions that you want to allow in this statement. For example,
        /// you can specify lambda:CreateFunction to specify a certain action, or use
        /// a wildcard (``lambda:*``) to grant permission to all Lambda actions. For a
        /// list of actions, see Actions and Condition Context Keys for AWS Lambda in
        /// the IAM User Guide.
        /// </summary>
        /// <remarks>default: 'lambda:InvokeFunction'</remarks>
        [JsiiProperty("action", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Action
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// A unique token that must be supplied by the principal invoking the
        /// function.
        /// </summary>
        /// <remarks>default: The caller would not need to present a token.</remarks>
        [JsiiProperty("eventSourceToken", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string EventSourceToken
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The entity for which you are granting permission to invoke the Lambda
        /// function. This entity can be any valid AWS service principal, such as
        /// s3.amazonaws.com or sns.amazonaws.com, or, if you are granting
        /// cross-account permission, an AWS account ID. For example, you might want
        /// to allow a custom application in another AWS account to push events to
        /// Lambda by invoking your function.
        /// 
        /// The principal can be either an AccountPrincipal or a ServicePrincipal.
        /// </summary>
        [JsiiProperty("principal", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyPrincipal\"}")]
        public virtual PolicyPrincipal Principal
        {
            get => GetProperty<PolicyPrincipal>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The AWS account ID (without hyphens) of the source owner. For example, if
        /// you specify an S3 bucket in the SourceArn property, this value is the
        /// bucket owner's account ID. You can use this property to ensure that all
        /// source principals are owned by a specific account.
        /// </summary>
        [JsiiProperty("sourceAccount", "{\"primitive\":\"any\",\"optional\":true}")]
        public virtual object SourceAccount
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The ARN of a resource that is invoking your function. When granting
        /// Amazon Simple Storage Service (Amazon S3) permission to invoke your
        /// function, specify this property with the bucket ARN as its value. This
        /// ensures that events generated only from the specified bucket, not just
        /// any bucket from any AWS account that creates a mapping to your function,
        /// can invoke the function.
        /// </summary>
        [JsiiProperty("sourceArn", "{\"fqn\":\"jsii$_aws_cdk_core$.Arn\",\"optional\":true}")]
        public virtual Arn SourceArn
        {
            get => GetProperty<Arn>();
            set => SetProperty(value);
        }
    }
}