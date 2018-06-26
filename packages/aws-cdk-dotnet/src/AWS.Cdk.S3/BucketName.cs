using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.S3
{
    /// <summary>The name of the bucket.</summary>
    [JsiiClass("@aws-cdk/s3", "jsii$_aws_cdk_s3$.BucketName", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class BucketName : Token
    {
        public BucketName(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected BucketName(ByRefValue reference): base(reference)
        {
        }

        protected BucketName(DeputyProps props): base(props)
        {
        }
    }
}