using AWS.Jsii.Runtime.Deputy;
using System;

namespace Aws.Cdk.S3
{
    /// <summary>Describes when an object transitions to a specified storage class.</summary>
    [JsiiInterfaceProxy("@aws-cdk/s3", "jsii$_aws_cdk_s3$.Transition")]
    public class TransitionProxy : DeputyBase, ITransition
    {
        private TransitionProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The storage class to which you want the object to transition.</summary>
        [JsiiProperty("storageClass", "{\"fqn\":\"jsii$_aws_cdk_s3$.StorageClass\"}")]
        public virtual StorageClass StorageClass
        {
            get => GetProperty<StorageClass>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Indicates when objects are transitioned to the specified storage class.
        /// 
        /// The date value must be in ISO 8601 format. The time is always midnight UTC.
        /// </summary>
        /// <remarks>default: No transition date.</remarks>
        [JsiiProperty("transitionDate", "{\"primitive\":\"date\",\"optional\":true}")]
        public virtual DateTime? TransitionDate
        {
            get => GetProperty<DateTime? >();
            set => SetProperty(value);
        }

        /// <summary>Indicates the number of days after creation when objects are transitioned to the specified storage class.</summary>
        /// <remarks>default: No transition count.</remarks>
        [JsiiProperty("transitionInDays", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? TransitionInDays
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }
    }
}