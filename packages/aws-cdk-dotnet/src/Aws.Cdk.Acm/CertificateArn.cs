using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Acm
{
    /// <summary>Represents the ARN of a certificate</summary>
    [JsiiClass("@aws-cdk/acm", "jsii$_aws_cdk_acm$.CertificateArn", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class CertificateArn : Arn
    {
        public CertificateArn(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected CertificateArn(ByRefValue reference): base(reference)
        {
        }

        protected CertificateArn(DeputyProps props): base(props)
        {
        }
    }
}