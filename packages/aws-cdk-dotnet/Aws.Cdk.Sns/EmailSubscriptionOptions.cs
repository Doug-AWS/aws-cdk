using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Sns
{
    /// <summary>Options for email subscriptions.</summary>
    public class EmailSubscriptionOptions : DeputyBase, IEmailSubscriptionOptions
    {
        /// <summary>
        /// Indicates if the full notification JSON should be sent to the email
        /// address or just the message text.
        /// </summary>
        /// <remarks>default: Message text (false)</remarks>
        [JsiiProperty("json", "{\"primitive\":\"boolean\",\"optional\":true}", true)]
        public bool? Json
        {
            get;
            set;
        }
    }
}