using AWS.Cdk;
using AWS.Cdk.Kms;
using AWS.Cdk.Resources.kinesis;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Kinesis
{
    /// <summary>A Kinesis stream. Can be encrypted with a KMS key.</summary>
    [JsiiClass("@aws-cdk/kinesis", "jsii$_aws_cdk_kinesis$.Stream", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_kinesis$.StreamProps\",\"optional\":true}}]")]
    public class Stream : StreamRef
    {
        public Stream(Construct parent, string name, IStreamProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Stream(ByRefValue reference): base(reference)
        {
        }

        protected Stream(DeputyProps props): base(props)
        {
        }

        /// <summary>The ARN of the stream.</summary>
        [JsiiProperty("streamArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.kinesis.StreamArn\"}")]
        public override StreamArn StreamArn
        {
            get => GetProperty<StreamArn>();
        }

        [JsiiProperty("streamName", "{\"fqn\":\"jsii$_aws_cdk_kinesis$.StreamName\"}")]
        public virtual StreamName StreamName
        {
            get => GetProperty<StreamName>();
        }

        /// <summary>Optional KMS encryption key associated with this stream.</summary>
        [JsiiProperty("encryptionKey", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRef\",\"optional\":true}")]
        public override EncryptionKeyRef EncryptionKey
        {
            get => GetProperty<EncryptionKeyRef>();
        }
    }
}