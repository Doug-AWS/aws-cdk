using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Route53
{
    /// <summary>Imported or created hosted zone</summary>
    [JsiiClass("@aws-cdk/route53", "jsii$_aws_cdk_route53$.HostedZoneRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class HostedZoneRef : Construct
    {
        protected HostedZoneRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected HostedZoneRef(ByRefValue reference): base(reference)
        {
        }

        protected HostedZoneRef(DeputyProps props): base(props)
        {
        }

        /// <summary>ID of this hosted zone</summary>
        [JsiiProperty("hostedZoneId", "{\"fqn\":\"jsii$_aws_cdk_route53$.HostedZoneId\"}")]
        public virtual HostedZoneId HostedZoneId
        {
            get => GetProperty<HostedZoneId>();
        }

        /// <summary>FQDN of this hosted zone</summary>
        [JsiiProperty("zoneName", "{\"primitive\":\"string\"}")]
        public virtual string ZoneName
        {
            get => GetProperty<string>();
        }

        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_route53$.HostedZoneRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_route53$.HostedZoneRefProps\"}}]")]
        public virtual HostedZoneRef Import(Construct parent, string name, IHostedZoneRefProps props)
        {
            return InvokeMethod<HostedZoneRef>(new object[]{parent, name, props});
        }

        /// <summary>Export the hosted zone</summary>
        [JsiiMethod("export", "{\"fqn\":\"jsii$_aws_cdk_route53$.HostedZoneRefProps\"}", "[]")]
        public virtual IHostedZoneRefProps Export()
        {
            return InvokeMethod<IHostedZoneRefProps>(new object[]{});
        }
    }
}