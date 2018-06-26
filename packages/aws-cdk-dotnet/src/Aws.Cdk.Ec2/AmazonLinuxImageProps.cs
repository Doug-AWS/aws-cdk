using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>Amazon Linux image properties</summary>
    public class AmazonLinuxImageProps : DeputyBase, IAmazonLinuxImageProps
    {
        /// <summary>What edition of Amazon Linux to use</summary>
        /// <remarks>default: Standard</remarks>
        [JsiiProperty("edition", "{\"primitive\":\"string\",\"optional\":true}", true)]
        public string Edition
        {
            get;
            set;
        }

        /// <summary>Virtualization type</summary>
        /// <remarks>default: HVM</remarks>
        [JsiiProperty("virtualization", "{\"primitive\":\"string\",\"optional\":true}", true)]
        public string Virtualization
        {
            get;
            set;
        }

        /// <summary>What storage backed image to use</summary>
        /// <remarks>default: GeneralPurpose</remarks>
        [JsiiProperty("storage", "{\"primitive\":\"string\",\"optional\":true}", true)]
        public string Storage
        {
            get;
            set;
        }
    }
}