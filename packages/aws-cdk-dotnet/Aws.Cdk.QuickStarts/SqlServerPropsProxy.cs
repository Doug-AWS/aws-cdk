using Aws.Cdk.Ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.QuickStarts
{
    [JsiiInterfaceProxy("@aws-cdk/quickstarts", "jsii$_aws_cdk_quickstarts$.SqlServerProps")]
    public class SqlServerPropsProxy : DeputyBase, ISqlServerProps
    {
        private SqlServerPropsProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("instanceClass", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string InstanceClass
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("engine", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Engine
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("engineVersion", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string EngineVersion
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("licenseModel", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string LicenseModel
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("masterUsername", "{\"primitive\":\"string\"}")]
        public virtual string MasterUsername
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("masterPassword", "{\"primitive\":\"string\"}")]
        public virtual string MasterPassword
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [JsiiProperty("allocatedStorage", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? AllocatedStorage
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        [JsiiProperty("vpc", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}")]
        public virtual VpcNetworkRef Vpc
        {
            get => GetProperty<VpcNetworkRef>();
            set => SetProperty(value);
        }
    }
}