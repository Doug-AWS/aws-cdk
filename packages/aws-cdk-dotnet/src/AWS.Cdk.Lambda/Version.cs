using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Lambda
{
    /// <summary>
    /// A single newly-deployed version of a Lambda function.
    /// 
    /// This object exists to--at deploy time--query the "then-current" version of
    /// the Lambda function that it refers to. This Version object can then be
    /// used in `Alias` to refer to a particular deployment of a Lambda.
    /// 
    /// This means that for every new update you deploy to your Lambda (using the
    /// CDK and Aliases), you must always create a new Version object. In
    /// particular, it must have a different name, so that a new resource is
    /// created.
    /// 
    /// If you want to ensure that you're associating the right version with
    /// the right deployment, specify the `codeSha256` property while
    /// creating the `Version.
    ///  *
    /// </summary>
    [JsiiClass("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.Version", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_lambda$.VersionProps\"}}]")]
    public class Version : Construct
    {
        public Version(Construct parent, string name, IVersionProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Version(ByRefValue reference): base(reference)
        {
        }

        protected Version(DeputyProps props): base(props)
        {
        }

        /// <summary>The most recently deployed version of this function.</summary>
        [JsiiProperty("functionVersion", "{\"fqn\":\"jsii$_aws_cdk_lambda$.FunctionVersion\"}")]
        public virtual FunctionVersion FunctionVersion
        {
            get => GetProperty<FunctionVersion>();
        }

        /// <summary>Lambda object this version is associated with</summary>
        [JsiiProperty("lambda", "{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRef\"}")]
        public virtual LambdaRef Lambda
        {
            get => GetProperty<LambdaRef>();
        }
    }
}