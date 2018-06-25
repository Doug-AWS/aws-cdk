using Aws.Cdk.Ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.QuickStarts
{
    [JsiiInterfaceProxy("@aws-cdk/quickstarts", "jsii$_aws_cdk_quickstarts$.RemoteDesktopGatewayProps")]
    public class RemoteDesktopGatewayPropsProxy : DeputyBase, IRemoteDesktopGatewayProps
    {
        private RemoteDesktopGatewayPropsProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("rdgwCIDR", "{\"primitive\":\"string\"}")]
        public virtual string RdgwCIDR
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("vpc", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}")]
        public virtual VpcNetworkRef Vpc
        {
            get => GetProperty<VpcNetworkRef>();
            set => SetProperty(value);
        }

        [JsiiProperty("keyPairName", "{\"primitive\":\"string\"}")]
        public virtual string KeyPairName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("adminPassword", "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("adminUser", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string AdminUser
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("domainDNSName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string DomainDNSName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("numberOfRDGWHosts", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? NumberOfRDGWHosts
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        [JsiiProperty("qss3BucketName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Qss3BucketName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("qss3KeyPrefix", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Qss3KeyPrefix
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("rdgwInstanceType", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string RdgwInstanceType
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}