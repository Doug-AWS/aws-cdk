using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.S3
{
    /// <summary>Applies an Amazon S3 bucket policy to an Amazon S3 bucket.</summary>
    [JsiiClass("@aws-cdk/s3", "jsii$_aws_cdk_s3$.BucketPolicy", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_s3$.BucketPolicyProps\"}}]")]
    public class BucketPolicy : Construct
    {
        public BucketPolicy(Construct parent, string name, IBucketPolicyProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected BucketPolicy(ByRefValue reference): base(reference)
        {
        }

        protected BucketPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>
        /// A policy document containing permissions to add to the specified bucket.
        /// For more information, see Access Policy Language Overview in the Amazon
        /// Simple Storage Service Developer Guide.
        /// </summary>
        [JsiiProperty("document", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyDocument\"}")]
        public virtual PolicyDocument Document
        {
            get => GetProperty<PolicyDocument>();
        }
    }
}