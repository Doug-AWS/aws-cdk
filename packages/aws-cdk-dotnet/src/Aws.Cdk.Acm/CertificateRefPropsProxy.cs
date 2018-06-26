using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Acm
{
    /// <summary>Reference to an existing Certificate</summary>
    [JsiiInterfaceProxy("@aws-cdk/acm", "jsii$_aws_cdk_acm$.CertificateRefProps")]
    public class CertificateRefPropsProxy : DeputyBase, ICertificateRefProps
    {
        private CertificateRefPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The certificate's ARN</summary>
        [JsiiProperty("certificateArn", "{\"fqn\":\"jsii$_aws_cdk_acm$.CertificateArn\"}")]
        public virtual CertificateArn CertificateArn
        {
            get => GetProperty<CertificateArn>();
            set => SetProperty(value);
        }
    }
}