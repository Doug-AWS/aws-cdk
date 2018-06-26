using AWS.Cdk.Lambda;
using AWS.Cdk.Sns;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace AWS.Cdk.CustomResources
{
    /// <summary>Properties to provide a Lambda-backed custom resource</summary>
    [JsiiInterfaceProxy("@aws-cdk/custom-resources", "jsii$_aws_cdk_custom_resources$.CustomResourceProps")]
    public class CustomResourcePropsProxy : DeputyBase, ICustomResourceProps
    {
        private CustomResourcePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The Lambda provider that implements this custom resource.
        /// 
        /// We recommend using a SingletonLambda for this.
        /// 
        /// Optional, exactly one of lamdaProvider or topicProvider must be set.
        /// </summary>
        [JsiiProperty("lambdaProvider", "{\"fqn\":\"jsii$_aws_cdk_lambda$.LambdaRef\",\"optional\":true}")]
        public virtual LambdaRef LambdaProvider
        {
            get => GetProperty<LambdaRef>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The SNS Topic for the provider that implements this custom resource.
        /// 
        /// Optional, exactly one of lamdaProvider or topicProvider must be set.
        /// </summary>
        [JsiiProperty("topicProvider", "{\"fqn\":\"jsii$_aws_cdk_sns$.TopicRef\",\"optional\":true}")]
        public virtual TopicRef TopicProvider
        {
            get => GetProperty<TopicRef>();
            set => SetProperty(value);
        }

        /// <summary>Properties to pass to the Lambda</summary>
        [JsiiProperty("properties", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}},\"optional\":true}")]
        public virtual IDictionary<string, object> Properties
        {
            get => GetProperty<IDictionary<string, object>>();
            set => SetProperty(value);
        }
    }
}