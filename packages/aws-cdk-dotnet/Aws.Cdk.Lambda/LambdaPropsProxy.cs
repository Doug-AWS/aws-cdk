using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Aws.Cdk.Lambda
{
    [JsiiInterfaceProxy("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.LambdaProps")]
    public class LambdaPropsProxy : DeputyBase, ILambdaProps
    {
        private LambdaPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The source code of your Lambda function. You can point to a file in an
        /// Amazon Simple Storage Service (Amazon S3) bucket or specify your source
        /// code as inline text.
        /// </summary>
        [JsiiProperty("code", "{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaCode\"}")]
        public virtual LambdaCode Code
        {
            get => GetProperty<LambdaCode>();
            set => SetProperty(value);
        }

        /// <summary>A description of the function.</summary>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Description
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The name of the function (within your source code) that Lambda calls to
        /// start running your code. For more information, see the Handler property
        /// in the AWS Lambda Developer Guide.
        /// 
        /// NOTE: If you specify your source code as inline text by specifying the
        /// ZipFile property within the Code property, specify index.function_name as
        /// the handler.
        /// </summary>
        [JsiiProperty("handler", "{\"primitive\":\"string\"}")]
        public virtual string Handler
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The function execution time (in seconds) after which Lambda terminates
        /// the function. Because the execution time affects cost, set this value
        /// based on the function's expected execution time.
        /// </summary>
        /// <remarks>default: 3 seconds.</remarks>
        [JsiiProperty("timeout", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? Timeout
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// Key-value pairs that Lambda caches and makes available for your Lambda
        /// functions. Use environment variables to apply configuration changes, such
        /// as test and production environment configurations, without changing your
        /// Lambda function source code.
        /// </summary>
        [JsiiProperty("environment", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}},\"optional\":true}")]
        public virtual IDictionary<string, object> Environment
        {
            get => GetProperty<IDictionary<string, object>>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The runtime environment for the Lambda function that you are uploading.
        /// For valid values, see the Runtime property in the AWS Lambda Developer
        /// Guide.
        /// </summary>
        [JsiiProperty("runtime", "{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRuntime\"}")]
        public virtual LambdaRuntime Runtime
        {
            get => GetProperty<LambdaRuntime>();
            set => SetProperty(value);
        }

        /// <summary>
        /// A name for the function. If you don't specify a name, AWS CloudFormation
        /// generates a unique physical ID and uses that ID for the function's name.
        /// For more information, see Name Type.
        /// </summary>
        [JsiiProperty("functionName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string FunctionName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The amount of memory, in MB, that is allocated to your Lambda function.
        /// Lambda uses this value to proportionally allocate the amount of CPU
        /// power. For more information, see Resource Model in the AWS Lambda
        /// Developer Guide.
        /// </summary>
        /// <remarks>default: The default value is 128 MB</remarks>
        [JsiiProperty("memorySize", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MemorySize
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// Initial policy statements to add to the created Lambda Role.
        /// 
        /// You can call `addToRolePolicy` to the created lambda to add statements post creation.
        /// </summary>
        [JsiiProperty("initialPolicy", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}},\"optional\":true}")]
        public virtual PolicyStatement[] InitialPolicy
        {
            get => GetProperty<PolicyStatement[]>();
            set => SetProperty(value);
        }
    }
}