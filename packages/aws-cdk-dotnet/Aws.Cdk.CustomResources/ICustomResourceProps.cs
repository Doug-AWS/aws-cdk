using Aws.Cdk.Lambda;
using Aws.Cdk.Sns;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Aws.Cdk.CustomResources
{
    /// <summary>Properties to provide a Lambda-backed custom resource</summary>
    [JsiiInterface("@aws-cdk/custom-resources", "jsii$_aws_cdk_custom_resources$.CustomResourceProps")]
    public interface ICustomResourceProps
    {
        /// <summary>
        /// The Lambda provider that implements this custom resource.
        /// 
        /// We recommend using a SingletonLambda for this.
        /// 
        /// Optional, exactly one of lamdaProvider or topicProvider must be set.
        /// </summary>
        [JsiiProperty("lambdaProvider", "{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRef\",\"optional\":true}")]
        LambdaRef LambdaProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The SNS Topic for the provider that implements this custom resource.
        /// 
        /// Optional, exactly one of lamdaProvider or topicProvider must be set.
        /// </summary>
        [JsiiProperty("topicProvider", "{\"fqn\":\"jsii$_aws_cdk_sns$.TopicRef\",\"optional\":true}")]
        TopicRef TopicProvider
        {
            get;
            set;
        }

        /// <summary>Properties to pass to the Lambda</summary>
        [JsiiProperty("properties", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}},\"optional\":true}")]
        IDictionary<string, object> Properties
        {
            get;
            set;
        }
    }
}