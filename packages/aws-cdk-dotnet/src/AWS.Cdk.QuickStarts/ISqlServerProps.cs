using AWS.Cdk.Ec2;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.QuickStarts
{
    [JsiiInterface("@aws-cdk/quickstarts", "jsii$_aws_cdk_quickstarts$.SqlServerProps")]
    public interface ISqlServerProps
    {
        [JsiiProperty("instanceClass", "{\"primitive\":\"string\",\"optional\":true}")]
        string InstanceClass
        {
            get;
            set;
        }

        [JsiiProperty("engine", "{\"primitive\":\"string\",\"optional\":true}")]
        string Engine
        {
            get;
            set;
        }

        [JsiiProperty("engineVersion", "{\"primitive\":\"string\",\"optional\":true}")]
        string EngineVersion
        {
            get;
            set;
        }

        [JsiiProperty("licenseModel", "{\"primitive\":\"string\",\"optional\":true}")]
        string LicenseModel
        {
            get;
            set;
        }

        [JsiiProperty("masterUsername", "{\"primitive\":\"string\"}")]
        string MasterUsername
        {
            get;
            set;
        }

        [JsiiProperty("masterPassword", "{\"primitive\":\"string\"}")]
        string MasterPassword
        {
            get;
            set;
        }

        [JsiiProperty("allocatedStorage", "{\"primitive\":\"number\",\"optional\":true}")]
        double? AllocatedStorage
        {
            get;
            set;
        }

        [JsiiProperty("vpc", "{\"fqn\":\"jsii$_aws_cdk_ec2$.VpcNetworkRef\"}")]
        VpcNetworkRef Vpc
        {
            get;
            set;
        }
    }
}