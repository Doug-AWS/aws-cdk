using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Route53
{
    [JsiiInterfaceProxy("@aws-cdk/route53", "jsii$_aws_cdk_route53$.TXTRecordProps")]
    public class TXTRecordPropsProxy : DeputyBase, ITXTRecordProps
    {
        private TXTRecordPropsProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("recordName", "{\"primitive\":\"string\"}")]
        public virtual string RecordName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("recordValue", "{\"primitive\":\"string\"}")]
        public virtual string RecordValue
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <remarks>default: 1800 seconds </remarks>
        [JsiiProperty("ttl", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? Ttl
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }
    }
}