using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Add a backend to the load balancer</summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.ClassicLoadBalancerListener")]
    public class ClassicLoadBalancerListenerProxy : DeputyBase, IClassicLoadBalancerListener
    {
        private ClassicLoadBalancerListenerProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>External listening port</summary>
        [JsiiProperty("externalPort", "{\"primitive\":\"number\"}")]
        public virtual double ExternalPort
        {
            get => GetProperty<double>();
            set => SetProperty(value);
        }

        /// <summary>
        /// What public protocol to use for load balancing
        /// 
        /// Either 'tcp', 'ssl', 'http' or 'https'.
        /// 
        /// May be omitted if the external port is either 80 or 443.
        /// </summary>
        [JsiiProperty("externalProtocol", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string ExternalProtocol
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Instance listening port
        /// 
        /// Same as the externalPort if not specified.
        /// </summary>
        /// <remarks>default: externalPort</remarks>
        [JsiiProperty("internalPort", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? InternalPort
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// What public protocol to use for load balancing
        /// 
        /// Either 'tcp', 'ssl', 'http' or 'https'.
        /// 
        /// May be omitted if the internal port is either 80 or 443.
        /// 
        /// The instance protocol is 'tcp' if the front-end protocol
        /// is 'tcp' or 'ssl', the instance protocol is 'http' if the
        /// front-end protocol is 'https'.
        /// </summary>
        [JsiiProperty("internalProtocol", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string InternalProtocol
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>SSL policy names</summary>
        [JsiiProperty("policyNames", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}},\"optional\":true}")]
        public virtual string[] PolicyNames
        {
            get => GetProperty<string[]>();
            set => SetProperty(value);
        }

        /// <summary>ID of SSL certificate</summary>
        [JsiiProperty("sslCertificateId", "{\"fqn\":\"jsii$_aws_cdk_core$.Arn\",\"optional\":true}")]
        public virtual Arn SslCertificateId
        {
            get => GetProperty<Arn>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Allow connections to the load balancer from the given set of connection peers
        /// 
        /// By default, connections will be allowed from anywhere. Set this to an empty list
        /// to deny connections, or supply a custom list of peers to allow connections from
        /// (IP ranges or security groups).
        /// </summary>
        /// <remarks>default: Anywhere</remarks>
        [JsiiProperty("allowConnectionsFrom", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectable\"}},\"optional\":true}")]
        public virtual IIConnectable[] AllowConnectionsFrom
        {
            get => GetProperty<IIConnectable[]>();
            set => SetProperty(value);
        }
    }
}