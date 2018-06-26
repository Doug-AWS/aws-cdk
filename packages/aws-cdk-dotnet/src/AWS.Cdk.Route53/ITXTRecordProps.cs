using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Route53
{
    [JsiiInterface("@aws-cdk/route53", "jsii$_aws_cdk_route53$.TXTRecordProps")]
    public interface ITXTRecordProps
    {
        [JsiiProperty("recordName", "{\"primitive\":\"string\"}")]
        string RecordName
        {
            get;
            set;
        }

        [JsiiProperty("recordValue", "{\"primitive\":\"string\"}")]
        string RecordValue
        {
            get;
            set;
        }

        /// <remarks>default: 1800 seconds </remarks>
        [JsiiProperty("ttl", "{\"primitive\":\"number\",\"optional\":true}")]
        double? Ttl
        {
            get;
            set;
        }
    }
}