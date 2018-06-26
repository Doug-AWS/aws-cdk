using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Amazon Linux image properties</summary>
    [JsiiInterface("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.AmazonLinuxImageProps")]
    public interface IAmazonLinuxImageProps
    {
        /// <summary>What edition of Amazon Linux to use</summary>
        /// <remarks>default: Standard</remarks>
        [JsiiProperty("edition", "{\"primitive\":\"string\",\"optional\":true}")]
        string Edition
        {
            get;
            set;
        }

        /// <summary>Virtualization type</summary>
        /// <remarks>default: HVM</remarks>
        [JsiiProperty("virtualization", "{\"primitive\":\"string\",\"optional\":true}")]
        string Virtualization
        {
            get;
            set;
        }

        /// <summary>What storage backed image to use</summary>
        /// <remarks>default: GeneralPurpose</remarks>
        [JsiiProperty("storage", "{\"primitive\":\"string\",\"optional\":true}")]
        string Storage
        {
            get;
            set;
        }
    }
}