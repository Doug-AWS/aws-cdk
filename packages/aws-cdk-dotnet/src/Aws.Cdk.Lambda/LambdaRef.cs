using Aws.Cdk;
using Aws.Cdk.Events;
using Aws.Cdk.Iam;
using Aws.Cdk.Resources.lambda;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Lambda
{
    [JsiiClass("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.LambdaRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class LambdaRef : Construct, IIEventRuleTarget
    {
        protected LambdaRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected LambdaRef(ByRefValue reference): base(reference)
        {
        }

        protected LambdaRef(DeputyProps props): base(props)
        {
        }

        /// <summary>The name of the function.</summary>
        [JsiiProperty("functionName", "{\"fqn\":\"jsii$_aws_cdk_lambda$.FunctionName\"}")]
        public virtual FunctionName FunctionName
        {
            get => GetProperty<FunctionName>();
        }

        /// <summary>The ARN fo the function.</summary>
        [JsiiProperty("functionArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.lambda.FunctionArn\"}")]
        public virtual FunctionArn FunctionArn
        {
            get => GetProperty<FunctionArn>();
        }

        /// <summary>The IAM role associated with this function.</summary>
        [JsiiProperty("role", "{\"fqn\":\"jsii$_aws_cdk_iam$.Role\",\"optional\":true}")]
        public virtual Role Role
        {
            get => GetProperty<Role>();
        }

        /// <summary>
        /// Whether the addPermission() call adds any permissions
        /// 
        /// True for new Lambdas, false for imported Lambdas (they might live in different accounts).
        /// </summary>
        [JsiiProperty("canCreatePermissions", "{\"primitive\":\"boolean\"}")]
        protected virtual bool CanCreatePermissions
        {
            get => GetProperty<bool>();
        }

        /// <summary>
        /// Returns a RuleTarget that can be used to trigger this Lambda as a
        /// result from a CloudWatch event.
        /// </summary>
        [JsiiProperty("eventRuleTarget", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleTarget\"}")]
        public virtual IEventRuleTarget EventRuleTarget
        {
            get => GetProperty<IEventRuleTarget>();
        }

        /// <summary>
        /// Creates a Lambda function object which represents a function not defined
        /// within this stack.
        /// 
        ///       Lambda.import(this, 'MyImportedFunction', { lambdaArn: new LambdaArn('arn:aws:...') });
        /// </summary>
        /// <param name = "parent">The parent construct</param>
        /// <param name = "name">The name of the lambda construct</param>
        /// <param name = "@ref">
        /// A reference to a Lambda function. Can be created manually (see
        /// example above) or obtained through a call to `lambda.export()`.
        /// </param>
        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"ref\",\"type\":{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRefProps\"}}]")]
        public virtual LambdaRef Import(Construct parent, string name, ILambdaRefProps @ref)
        {
            return InvokeMethod<LambdaRef>(new object[]{parent, name, @ref});
        }

        /// <summary>Adds a permission to the Lambda resource policy.</summary>
        /// <param name = "name">A name for the permission construct</param>
        [JsiiMethod("addPermission", null, "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"permission\",\"type\":{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaPermission\"}}]")]
        public virtual void AddPermission(string name, ILambdaPermission permission)
        {
            InvokeVoidMethod(new object[]{name, permission});
        }

        [JsiiMethod("addToRolePolicy", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddToRolePolicy(PolicyStatement statement)
        {
            InvokeVoidMethod(new object[]{statement});
        }
    }
}