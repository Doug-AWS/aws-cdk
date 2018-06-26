using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Kms
{
    /// <summary>Construction properties for a KMS Key object</summary>
    [JsiiInterfaceProxy("@aws-cdk/kms", "jsii$_aws_cdk_kms$.EncryptionKeyProps")]
    public class EncryptionKeyPropsProxy : DeputyBase, IEncryptionKeyProps
    {
        private EncryptionKeyPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// A description of the key. Use a description that helps your users decide
        /// whether the key is appropriate for a particular task.
        /// </summary>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Description
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Indicates whether AWS KMS rotates the key.</summary>
        /// <remarks>default: false</remarks>
        [JsiiProperty("enableKeyRotation", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? EnableKeyRotation
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>Indicates whether the key is available for use.</summary>
        /// <remarks>default: Key is enabled</remarks>
        [JsiiProperty("enabled", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? Enabled
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>Custom policy document to attach to the KMS key.</summary>
        /// <remarks>
        /// default: A policy document with permissions for the account root to
        /// administer the key will be created.
        /// </remarks>
        [JsiiProperty("policy", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyDocument\",\"optional\":true}")]
        public virtual PolicyDocument Policy
        {
            get => GetProperty<PolicyDocument>();
            set => SetProperty(value);
        }
    }
}