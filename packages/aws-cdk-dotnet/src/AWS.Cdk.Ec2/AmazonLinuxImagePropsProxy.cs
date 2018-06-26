using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Amazon Linux image properties</summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.AmazonLinuxImageProps")]
    public class AmazonLinuxImagePropsProxy : DeputyBase, IAmazonLinuxImageProps
    {
        private AmazonLinuxImagePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>What edition of Amazon Linux to use</summary>
        /// <remarks>default: Standard</remarks>
        [JsiiProperty("edition", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Edition
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Virtualization type</summary>
        /// <remarks>default: HVM</remarks>
        [JsiiProperty("virtualization", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Virtualization
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>What storage backed image to use</summary>
        /// <remarks>default: GeneralPurpose</remarks>
        [JsiiProperty("storage", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Storage
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}