using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.S3
{
    /// <summary>Describes when noncurrent versions transition to a specified storage class.</summary>
    [JsiiInterfaceProxy("@aws-cdk/s3", "jsii$_aws_cdk_s3$.NoncurrentVersionTransition")]
    public class NoncurrentVersionTransitionProxy : DeputyBase, INoncurrentVersionTransition
    {
        private NoncurrentVersionTransitionProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The storage class to which you want the object to transition.</summary>
        [JsiiProperty("storageClass", "{\"fqn\":\"jsii$_aws_cdk_s3$.StorageClass\"}")]
        public virtual StorageClass StorageClass
        {
            get => GetProperty<StorageClass>();
            set => SetProperty(value);
        }

        /// <summary>Indicates the number of days after creation when objects are transitioned to the specified storage class.</summary>
        /// <remarks>default: No transition count.</remarks>
        [JsiiProperty("transitionInDays", "{\"primitive\":\"number\"}")]
        public virtual double TransitionInDays
        {
            get => GetProperty<double>();
            set => SetProperty(value);
        }
    }
}