using Aws.Cdk;
using Aws.Cdk.Iam;
using Aws.Cdk.Resources.lambda;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Lambda
{
    /// <summary>
    /// Deploys a file from from inside the construct library as a function.
    /// 
    /// The supplied file is subject to the 4096 bytes limit of being embedded in a
    /// CloudFormation template.
    /// 
    /// The construct includes an associated role with the lambda.
    /// 
    /// This construct does not yet reproduce all features from the underlying resource
    /// library.
    /// </summary>
    [JsiiClass("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.Lambda", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaProps\"}}]")]
    public class Lambda : LambdaRef
    {
        public Lambda(Construct parent, string name, ILambdaProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Lambda(ByRefValue reference): base(reference)
        {
        }

        protected Lambda(DeputyProps props): base(props)
        {
        }

        /// <summary>Name of this function</summary>
        [JsiiProperty("functionName", "{\"fqn\":\"jsii$_aws_cdk_lambda$.FunctionName\"}")]
        public override FunctionName FunctionName
        {
            get => GetProperty<FunctionName>();
        }

        /// <summary>ARN of this function</summary>
        [JsiiProperty("functionArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.lambda.FunctionArn\"}")]
        public override FunctionArn FunctionArn
        {
            get => GetProperty<FunctionArn>();
        }

        /// <summary>Execution role associated with this function</summary>
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
        }

        /// <summary>
        /// Adds an environment variable to this Lambda function.
        /// If this is a ref to a Lambda function, this operation results in a no-op.
        /// </summary>
        /// <param name = "key">The environment variable key.</param>
        /// <param name = "value">The environment variable's value.</param>
        [JsiiMethod("addEnvironment", null, "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"value\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual void AddEnvironment(string key, object value)
        {
            InvokeVoidMethod(new object[]{key, value});
        }

        /// <summary>
        /// Add a new version for this Lambda
        /// 
        /// If you want to deploy through CloudFormation and use aliases, you need to
        /// add a new version (with a new name) to your Lambda every time you want
        /// to deploy an update. An alias can then refer to the newly created Version.
        /// 
        /// All versions should have distinct names, and you should not delete versions
        /// as long as your Alias needs to refer to them.
        /// </summary>
        /// <param name = "name">A unique name for this version</param>
        /// <param name = "codeSha256">
        /// The SHA-256 hash of the most recently deployed Lambda source code, or
        /// omit to skip validation.
        /// </param>
        /// <param name = "description">A description for this version.</param>
        /// <returns>A new Version object.</returns>
        [JsiiMethod("addVersion", "{\"fqn\":\"jsii$_aws_cdk_lambda$.Version\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"codeSha256\",\"type\":{\"primitive\":\"string\",\"optional\":true}},{\"name\":\"description\",\"type\":{\"primitive\":\"string\",\"optional\":true}}]")]
        public virtual Version AddVersion(string name, string codeSha256, string description)
        {
            return InvokeMethod<Version>(new object[]{name, codeSha256, description});
        }
    }
}