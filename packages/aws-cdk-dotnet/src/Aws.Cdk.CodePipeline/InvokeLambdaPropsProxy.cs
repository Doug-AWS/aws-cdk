using Aws.Cdk.Lambda;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    [JsiiInterfaceProxy("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.InvokeLambdaProps")]
    public class InvokeLambdaPropsProxy : DeputyBase, IInvokeLambdaProps
    {
        private InvokeLambdaPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The lambda function to invoke.</summary>
        [JsiiProperty("lambda", "{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRef\"}")]
        public virtual LambdaRef Lambda
        {
            get => GetProperty<LambdaRef>();
            set => SetProperty(value);
        }

        /// <summary>
        /// String to be used in the event data parameter passed to the Lambda
        /// function
        /// 
        /// See an example JSON event in the CodePipeline documentation.
        /// 
        /// https://docs.aws.amazon.com/codepipeline/latest/userguide/actions-invoke-lambda-function.html#actions-invoke-lambda-function-json-event-example
        /// </summary>
        [JsiiProperty("userParameters", "{\"primitive\":\"any\",\"optional\":true}")]
        public virtual object UserParameters
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Adds the "codepipeline:PutJobSuccessResult" and
        /// "codepipeline:PutJobFailureResult" for '*' resource to the Lambda
        /// execution role policy.
        /// 
        /// NOTE: the reason we can't add the specific pipeline ARN as a resource is
        /// to avoid a cyclic dependency between the pipeline and the Lambda function
        /// (the pipeline references) the Lambda and the Lambda needs permissions on
        /// the pipeline.
        /// </summary>
        /// <remarks>
        /// see: https://docs.aws.amazon.com/codepipeline/latest/userguide/actions-invoke-lambda-function.html#actions-invoke-lambda-function-create-function
        /// default: true
        /// </remarks>
        [JsiiProperty("addPutJobResultPolicy", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? AddPutJobResultPolicy
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }
    }
}