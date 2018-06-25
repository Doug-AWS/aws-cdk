using Aws.Cdk.Lambda;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    public class InvokeLambdaProps : DeputyBase, IInvokeLambdaProps
    {
        /// <summary>The lambda function to invoke.</summary>
        [JsiiProperty("lambda", "{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRef\"}", true)]
        public LambdaRef Lambda
        {
            get;
            set;
        }

        /// <summary>
        /// String to be used in the event data parameter passed to the Lambda
        /// function
        /// 
        /// See an example JSON event in the CodePipeline documentation.
        /// 
        /// https://docs.aws.amazon.com/codepipeline/latest/userguide/actions-invoke-lambda-function.html#actions-invoke-lambda-function-json-event-example
        /// </summary>
        [JsiiProperty("userParameters", "{\"primitive\":\"any\",\"optional\":true}", true)]
        public object UserParameters
        {
            get;
            set;
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
        [JsiiProperty("addPutJobResultPolicy", "{\"primitive\":\"boolean\",\"optional\":true}", true)]
        public bool? AddPutJobResultPolicy
        {
            get;
            set;
        }
    }
}