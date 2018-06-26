using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    /// <summary>Source that is provided by a specific Amazon S3 object</summary>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.AmazonS3Source", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Stage\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.AmazonS3SourceProps\"}}]")]
    public class AmazonS3Source : Source
    {
        public AmazonS3Source(Stage parent, string name, IAmazonS3SourceProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected AmazonS3Source(ByRefValue reference): base(reference)
        {
        }

        protected AmazonS3Source(DeputyProps props): base(props)
        {
        }
    }
}