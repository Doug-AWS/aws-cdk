using Aws.Cdk;
using Aws.Cdk.Resources.sns;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sns
{
    /// <summary>A new SNS topic</summary>
    [JsiiClass("@aws-cdk/sns", "jsii$_aws_cdk_sns$.Topic", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_sns$.TopicProps\",\"optional\":true}}]")]
    public class Topic : TopicRef
    {
        public Topic(Construct parent, string name, ITopicProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Topic(ByRefValue reference): base(reference)
        {
        }

        protected Topic(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("topicArn", "{\"fqn\":\"jsii$_aws_cdk_sns$.TopicArn\"}")]
        public override TopicArn TopicArn
        {
            get => GetProperty<TopicArn>();
        }

        [JsiiProperty("topicName", "{\"fqn\":\"jsii$_aws_cdk_resources$.sns.TopicName\",\"optional\":true}")]
        public virtual TopicName TopicName
        {
            get => GetProperty<TopicName>();
        }

        /// <summary>
        /// Controls automatic creation of policy objects.
        /// 
        /// Set by subclasses.
        /// </summary>
        [JsiiProperty("autoCreatePolicy", "{\"primitive\":\"boolean\"}")]
        protected override bool AutoCreatePolicy
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }
    }
}