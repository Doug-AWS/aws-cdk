using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sns
{
    /// <summary>
    /// A new subscription.
    /// 
    /// Prefer to use the `TopicRef.subscribeXxx()` methods to creating instances of
    /// this class.
    /// </summary>
    [JsiiClass("@aws-cdk/sns", "jsii$_aws_cdk_sns$.Subscription", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_sns$.SubscriptionProps\"}}]")]
    public class Subscription : Construct
    {
        public Subscription(Construct parent, string name, ISubscriptionProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Subscription(ByRefValue reference): base(reference)
        {
        }

        protected Subscription(DeputyProps props): base(props)
        {
        }
    }
}