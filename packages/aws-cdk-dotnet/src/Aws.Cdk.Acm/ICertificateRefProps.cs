using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Acm
{
    /// <summary>Reference to an existing Certificate</summary>
    [JsiiInterface("@aws-cdk/acm", "jsii$_aws_cdk_acm$.CertificateRefProps")]
    public interface ICertificateRefProps
    {
        /// <summary>The certificate's ARN</summary>
        [JsiiProperty("certificateArn", "{\"fqn\":\"jsii$_aws_cdk_acm$.CertificateArn\"}")]
        CertificateArn CertificateArn
        {
            get;
            set;
        }
    }
}