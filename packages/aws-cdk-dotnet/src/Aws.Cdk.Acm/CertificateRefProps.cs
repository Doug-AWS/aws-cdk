using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Acm
{
    /// <summary>Reference to an existing Certificate</summary>
    public class CertificateRefProps : DeputyBase, ICertificateRefProps
    {
        /// <summary>The certificate's ARN</summary>
        [JsiiProperty("certificateArn", "{\"fqn\":\"jsii$_aws_cdk_acm$.CertificateArn\"}", true)]
        public CertificateArn CertificateArn
        {
            get;
            set;
        }
    }
}