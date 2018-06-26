using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Acm
{
    /// <summary>
    /// A certificate managed by Amazon Certificate Manager
    /// 
    /// IMPORTANT: if you are creating a certificate as part of your stack, the stack
    /// will not complete creating until you read and follow the instructions in the
    /// email that you will receive.
    /// 
    /// ACM will send validation emails to the following addresses:
    /// 
    ///     admin@domain.com
    ///     administrator@domain.com
    ///     hostmaster@domain.com
    ///     postmaster@domain.com
    ///     webmaster@domain.com
    /// 
    /// For every domain that you register.
    /// </summary>
    [JsiiClass("@aws-cdk/acm", "jsii$_aws_cdk_acm$.Certificate", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_acm$.CertificateProps\"}}]")]
    public class Certificate : CertificateRef
    {
        public Certificate(Construct parent, string name, ICertificateProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Certificate(ByRefValue reference): base(reference)
        {
        }

        protected Certificate(DeputyProps props): base(props)
        {
        }

        /// <summary>The certificate's ARN</summary>
        [JsiiProperty("certificateArn", "{\"fqn\":\"jsii$_aws_cdk_acm$.CertificateArn\"}")]
        public override CertificateArn CertificateArn
        {
            get => GetProperty<CertificateArn>();
        }
    }
}