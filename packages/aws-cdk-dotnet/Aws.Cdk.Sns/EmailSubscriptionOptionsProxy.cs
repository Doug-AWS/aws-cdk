using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sns
{
    /// <summary>Options for email subscriptions.</summary>
    [JsiiInterfaceProxy("@aws-cdk/sns", "jsii$_aws_cdk_sns$.EmailSubscriptionOptions")]
    public class EmailSubscriptionOptionsProxy : DeputyBase, IEmailSubscriptionOptions
    {
        private EmailSubscriptionOptionsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// Indicates if the full notification JSON should be sent to the email
        /// address or just the message text.
        /// </summary>
        /// <remarks>default: Message text (false)</remarks>
        [JsiiProperty("json", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? Json
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }
    }
}