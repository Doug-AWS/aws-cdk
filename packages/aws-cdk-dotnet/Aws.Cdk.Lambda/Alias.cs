using Aws.Cdk;
using Aws.Cdk.Iam;
using Aws.Cdk.Resources.lambda;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Lambda
{
    /// <summary>A new alias to a particular version of a Lambda function.</summary>
    [JsiiClass("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.Alias", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_lambda$.AliasProps\"}}]")]
    public class Alias : LambdaRef
    {
        public Alias(Construct parent, string name, IAliasProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Alias(ByRefValue reference): base(reference)
        {
        }

        protected Alias(DeputyProps props): base(props)
        {
        }

        /// <summary>
        /// ARN of this alias
        /// 
        /// Used to be able to use Alias in place of a regular Lambda. Lambda accepts
        /// ARNs everywhere it accepts function names.
        /// </summary>
        [JsiiProperty("functionName", "{\"fqn\":\"jsii$_aws_cdk_lambda$.FunctionName\"}")]
        public override FunctionName FunctionName
        {
            get => GetProperty<FunctionName>();
        }

        /// <summary>
        /// ARN of this alias
        /// 
        /// Used to be able to use Alias in place of a regular Lambda. Lambda accepts
        /// ARNs everywhere it accepts function names.
        /// </summary>
        [JsiiProperty("functionArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.lambda.FunctionArn\"}")]
        public override FunctionArn FunctionArn
        {
            get => GetProperty<FunctionArn>();
        }

        /// <summary>Role associated with this alias</summary>
        [JsiiProperty("role", "{\"fqn\":\"jsii$_aws_cdk_iam$.Role\",\"optional\":true}")]
        public override Role Role
        {
            get => GetProperty<Role>();
        }

        /// <summary>
        /// Whether the addPermission() call adds any permissions
        /// 
        /// True for new Lambdas, false for imported Lambdas (they might live in different accounts).
        /// </summary>
        [JsiiProperty("canCreatePermissions", "{\"primitive\":\"boolean\"}")]
        protected override bool CanCreatePermissions
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }

        /// <summary>Adds a permission to the Lambda resource policy.</summary>
        [JsiiMethod("addPermission", null, "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"permission\",\"type\":{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaPermission\"}}]")]
        public override void AddPermission(string name, ILambdaPermission permission)
        {
            InvokeVoidMethod(new object[]{name, permission});
        }
    }
}