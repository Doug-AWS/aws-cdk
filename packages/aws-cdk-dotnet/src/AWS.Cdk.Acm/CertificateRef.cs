using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Acm
{
    /// <summary>Interface for certificate-like objects</summary>
    [JsiiClass("@aws-cdk/acm", "jsii$_aws_cdk_acm$.CertificateRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class CertificateRef : Construct
    {
        protected CertificateRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected CertificateRef(ByRefValue reference): base(reference)
        {
        }

        protected CertificateRef(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("certificateArn", "{\"fqn\":\"jsii$_aws_cdk_acm$.CertificateArn\"}")]
        public virtual CertificateArn CertificateArn
        {
            get => GetProperty<CertificateArn>();
        }

        /// <summary>Import a certificate</summary>
        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_acm$.CertificateRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_acm$.CertificateRefProps\"}}]")]
        public virtual CertificateRef Import(Construct parent, string name, ICertificateRefProps props)
        {
            return InvokeMethod<CertificateRef>(new object[]{parent, name, props});
        }

        /// <summary>Export this certificate from the stack</summary>
        [JsiiMethod("export", "{\"fqn\":\"jsii$_aws_cdk_acm$.CertificateRefProps\"}", "[]")]
        public virtual ICertificateRefProps Export()
        {
            return InvokeMethod<ICertificateRefProps>(new object[]{});
        }
    }
}