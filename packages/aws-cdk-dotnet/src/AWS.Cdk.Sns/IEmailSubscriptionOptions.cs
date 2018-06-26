using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sns
{
    /// <summary>Options for email subscriptions.</summary>
    [JsiiInterface("@aws-cdk/sns", "jsii$_aws_cdk_sns$.EmailSubscriptionOptions")]
    public interface IEmailSubscriptionOptions
    {
        /// <summary>
        /// Indicates if the full notification JSON should be sent to the email
        /// address or just the message text.
        /// </summary>
        /// <remarks>default: Message text (false)</remarks>
        [JsiiProperty("json", "{\"primitive\":\"boolean\",\"optional\":true}")]
        bool? Json
        {
            get;
            set;
        }
    }
}