using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Sns
{
    /// <summary>The type of subscription, controlling the type of the endpoint parameter.</summary>
    [JsiiEnum("@aws-cdk/sns", "jsii$_aws_cdk_sns$.SubscriptionProtocol")]
    public enum SubscriptionProtocol
    {
        [JsiiEnumMember("Http")]
        Http,
        [JsiiEnumMember("Https")]
        Https,
        [JsiiEnumMember("Email")]
        Email,
        [JsiiEnumMember("EmailJson")]
        EmailJson,
        [JsiiEnumMember("Sms")]
        Sms,
        [JsiiEnumMember("Sqs")]
        Sqs,
        [JsiiEnumMember("Application")]
        Application,
        [JsiiEnumMember("Lambda")]
        Lambda
    }
}