using AWS.Cdk;
using AWS.Cdk.Resources.codecommit;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodeCommit
{
    /// <summary>Provides a CodeCommit Repository</summary>
    [JsiiClass("@aws-cdk/codecommit", "jsii$_aws_cdk_codecommit$.Repository", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codecommit$.RepositoryProps\"}}]")]
    public class Repository : RepositoryRef
    {
        public Repository(Construct parent, string name, IRepositoryProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Repository(ByRefValue reference): base(reference)
        {
        }

        protected Repository(DeputyProps props): base(props)
        {
        }

        /// <summary>The ARN of this Repository. </summary>
        [JsiiProperty("repositoryArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.codecommit.RepositoryArn\"}")]
        public override RepositoryArn RepositoryArn
        {
            get => GetProperty<RepositoryArn>();
        }

        [JsiiProperty("repositoryCloneUrlHttp", "{\"fqn\":\"jsii$_aws_cdk_resources$.codecommit.RepositoryCloneUrlHttp\"}")]
        public virtual RepositoryCloneUrlHttp RepositoryCloneUrlHttp
        {
            get => GetProperty<RepositoryCloneUrlHttp>();
        }

        [JsiiProperty("repositoryCloneUrlSsh", "{\"fqn\":\"jsii$_aws_cdk_resources$.codecommit.RepositoryCloneUrlSsh\"}")]
        public virtual RepositoryCloneUrlSsh RepositoryCloneUrlSsh
        {
            get => GetProperty<RepositoryCloneUrlSsh>();
        }

        /// <summary>The human-visible name of this Repository. </summary>
        [JsiiProperty("repositoryName", "{\"fqn\":\"jsii$_aws_cdk_resources$.codecommit.RepositoryName\"}")]
        public override RepositoryName RepositoryName
        {
            get => GetProperty<RepositoryName>();
        }

        /// <summary>Create a trigger to notify another service to run actions on repository events.</summary>
        /// <param name = "arn">Arn of the resource that repository events will notify</param>
        /// <param name = "options">Trigger options to run actions</param>
        [JsiiMethod("notify", "{\"fqn\":\"jsii$_aws_cdk_codecommit$.Repository\"}", "[{\"name\":\"arn\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codecommit$.RepositoryTriggerOptions\",\"optional\":true}}]")]
        public virtual Repository Notify(string arn, IRepositoryTriggerOptions options)
        {
            return InvokeMethod<Repository>(new object[]{arn, options});
        }
    }
}