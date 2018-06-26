using AWS.Cdk;
using AWS.Cdk.Resources.elasticloadbalancing;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>
    /// A load balancer with a single listener
    /// 
    /// Routes to a fleet of of instances in a VPC.
    /// </summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.ClassicLoadBalancer", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.ClassicLoadBalancerProps\"}}]")]
    public class ClassicLoadBalancer : Construct, IIConnectable
    {
        public ClassicLoadBalancer(Construct parent, string name, IClassicLoadBalancerProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected ClassicLoadBalancer(ByRefValue reference): base(reference)
        {
        }

        protected ClassicLoadBalancer(DeputyProps props): base(props)
        {
        }

        /// <summary>Control all connections from and to this load balancer</summary>
        [JsiiProperty("connections", "{\"fqn\":\"jsii$_aws_cdk_ec2$.Connections\"}")]
        public virtual Connections Connections
        {
            get => GetProperty<Connections>();
        }

        [JsiiProperty("connectionPeer", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectionPeer\"}")]
        public virtual IIConnectionPeer ConnectionPeer
        {
            get => GetProperty<IIConnectionPeer>();
        }

        /// <summary>An object controlling specifically the connections for each listener added to this load balancer</summary>
        [JsiiProperty("listenerPorts", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_ec2$.ClassicListenerPort\"}}}")]
        public virtual ClassicListenerPort[] ListenerPorts
        {
            get => GetProperty<ClassicListenerPort[]>();
        }

        [JsiiProperty("loadBalancerName", "{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}")]
        public virtual Token LoadBalancerName
        {
            get => GetProperty<Token>();
        }

        [JsiiProperty("loadBalancerCanonicalHostedZoneName", "{\"fqn\":\"jsii$_aws_cdk_resources$.elasticloadbalancing.LoadBalancerCanonicalHostedZoneName\"}")]
        public virtual LoadBalancerCanonicalHostedZoneName LoadBalancerCanonicalHostedZoneName
        {
            get => GetProperty<LoadBalancerCanonicalHostedZoneName>();
        }

        [JsiiProperty("loadBalancerDnsName", "{\"fqn\":\"jsii$_aws_cdk_resources$.elasticloadbalancing.LoadBalancerDnsName\"}")]
        public virtual LoadBalancerDnsName LoadBalancerDnsName
        {
            get => GetProperty<LoadBalancerDnsName>();
        }

        [JsiiProperty("loadBalancerSourceSecurityGroupGroupName", "{\"fqn\":\"jsii$_aws_cdk_resources$.elasticloadbalancing.LoadBalancerSourceSecurityGroupGroupName\"}")]
        public virtual LoadBalancerSourceSecurityGroupGroupName LoadBalancerSourceSecurityGroupGroupName
        {
            get => GetProperty<LoadBalancerSourceSecurityGroupGroupName>();
        }

        [JsiiProperty("loadBalancerSourceSecurityGroupOwnerAlias", "{\"fqn\":\"jsii$_aws_cdk_resources$.elasticloadbalancing.LoadBalancerSourceSecurityGroupOwnerAlias\"}")]
        public virtual LoadBalancerSourceSecurityGroupOwnerAlias LoadBalancerSourceSecurityGroupOwnerAlias
        {
            get => GetProperty<LoadBalancerSourceSecurityGroupOwnerAlias>();
        }

        /// <summary>Add a backend to the load balancer</summary>
        /// <returns>A ClassicListenerPort object that controls connections to the listener port</returns>
        [JsiiMethod("addListener", "{\"fqn\":\"jsii$_aws_cdk_ec2$.ClassicListenerPort\"}", "[{\"name\":\"listener\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.ClassicLoadBalancerListener\"}}]")]
        public virtual ClassicListenerPort AddListener(IClassicLoadBalancerListener listener)
        {
            return InvokeMethod<ClassicListenerPort>(new object[]{listener});
        }

        [JsiiMethod("addTarget", null, "[{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.IClassicLoadBalancerTarget\"}}]")]
        public virtual void AddTarget(IIClassicLoadBalancerTarget target)
        {
            InvokeVoidMethod(new object[]{target});
        }
    }
}