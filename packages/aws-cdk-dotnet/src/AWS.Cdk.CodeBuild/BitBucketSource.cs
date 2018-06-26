using AWS.Cdk.Resources.codebuild.ProjectResource;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodeBuild
{
    /// <summary>BitBucket Source definition for a CodeBuild project</summary>
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.BitBucketSource", "[{\"name\":\"httpsCloneUrl\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BitBucketSource : BuildSource
    {
        public BitBucketSource(string httpsCloneUrl): base(new DeputyProps(new object[]{httpsCloneUrl}))
        {
        }

        protected BitBucketSource(ByRefValue reference): base(reference)
        {
        }

        protected BitBucketSource(DeputyProps props): base(props)
        {
        }

        [JsiiMethod("toSourceJSON", "{\"fqn\":\"jsii$_aws_cdk_resources$.codebuild.ProjectResource.SourceProperty\"}", "[]")]
        public override ISourceProperty ToSourceJSON()
        {
            return InvokeMethod<ISourceProperty>(new object[]{});
        }
    }
}