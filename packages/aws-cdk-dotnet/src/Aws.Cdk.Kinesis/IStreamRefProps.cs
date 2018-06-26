using Aws.Cdk.Kms;
using Aws.Cdk.Resources.kinesis;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Kinesis
{
    /// <summary>
    /// A reference to a stream. The easiest way to instantiate is to call
    /// `stream.export()`. Then, the consumer can use `Stream.import(this, ref)` and
    /// get a `Stream`.
    /// </summary>
    [JsiiInterface("@aws-cdk/kinesis", "jsii$_aws_cdk_kinesis$.StreamRefProps")]
    public interface IStreamRefProps
    {
        /// <summary>The ARN of the stream.</summary>
        [JsiiProperty("streamArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.kinesis.StreamArn\"}")]
        StreamArn StreamArn
        {
            get;
            set;
        }

        /// <summary>The KMS key securing the contents of the stream if encryption is enabled.</summary>
        [JsiiProperty("encryptionKey", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRefProps\",\"optional\":true}")]
        IEncryptionKeyRefProps EncryptionKey
        {
            get;
            set;
        }
    }
}