using AWS.Cdk.Iam;
using AWS.Cdk.Resources.lambda;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Lambda
{
    /// <summary>Represents a Lambda function defined outside of this stack.</summary>
    [JsiiInterface("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.LambdaRefProps")]
    public interface ILambdaRefProps
    {
        /// <summary>
        /// The ARN of the Lambda function.
        /// Format: arn:&lt;partition&gt;:lambda:&lt;region&gt;:&lt;account-id&gt;:function:&lt;function-name&gt;
        /// </summary>
        [JsiiProperty("functionArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.lambda.FunctionArn\"}")]
        FunctionArn FunctionArn
        {
            get;
            set;
        }

        /// <summary>
        /// The IAM execution role associated with this function.
        /// If the role is not specified, any role-related operations will no-op.
        /// </summary>
        [JsiiProperty("role", "{\"fqn\":\"jsii$_aws_cdk_iam$.Role\",\"optional\":true}")]
        Role Role
        {
            get;
            set;
        }
    }
}