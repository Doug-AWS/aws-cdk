using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>VpcNetworkProps allows you to specify configuration options for a VPC</summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.VpcNetworkProps")]
    public class VpcNetworkPropsProxy : DeputyBase, IVpcNetworkProps
    {
        private VpcNetworkPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The CIDR range to use for the VPC (e.g. '10.0.0.0/16'). Should be a minimum of /28 and maximum size of /16.
        /// The range will be split evenly into two subnets per Availability Zone (one public, one private).
        /// </summary>
        [JsiiProperty("cidr", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Cidr
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Indicates whether the instances launched in the VPC get public DNS hostnames.
        /// If this attribute is true, instances in the VPC get public DNS hostnames,
        /// but only if the enableDnsSupport attribute is also set to true.
        /// </summary>
        [JsiiProperty("enableDnsHostnames", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? EnableDnsHostnames
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// Indicates whether the DNS resolution is supported for the VPC. If this attribute
        /// is false, the Amazon-provided DNS server in the VPC that resolves public DNS hostnames
        /// to IP addresses is not enabled. If this attribute is true, queries to the Amazon
        /// provided DNS server at the 169.254.169.253 IP address, or the reserved IP address
        /// at the base of the VPC IPv4 network range plus two will succeed.
        /// </summary>
        [JsiiProperty("enableDnsSupport", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? EnableDnsSupport
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// The default tenancy of instances launched into the VPC.
        /// By default, instances will be launched with default (shared) tenancy.
        /// By setting this to dedicated tenancy, instances will be launched on hardware dedicated
        /// to a single AWS customer, unless specifically specified at instance launch time.
        /// Please note, not all instance types are usable with Dedicated tenancy.
        /// </summary>
        [JsiiProperty("defaultInstanceTenancy", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string DefaultInstanceTenancy
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The AWS resource tags to associate with the VPC.</summary>
        [JsiiProperty("tags", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_core$.Tag\"}},\"optional\":true}")]
        public virtual ITag[] Tags
        {
            get => GetProperty<ITag[]>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Defines whether the VPC is configured to route outbound traffic from private and/or public subnets.
        /// By default, outbound traffic will be allowed from public and private subnets.
        /// </summary>
        [JsiiProperty("outboundTraffic", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? OutboundTraffic
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// Define the maximum number of AZs to use in this region
        /// 
        /// If the region has more AZs than you want to use (for example, because of EIP limits),
        /// pick a lower number here. The AZs will be sorted and picked from the start of the list.
        /// </summary>
        /// <remarks>default: All AZs in the region</remarks>
        [JsiiProperty("maxAZs", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MaxAZs
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }
    }
}