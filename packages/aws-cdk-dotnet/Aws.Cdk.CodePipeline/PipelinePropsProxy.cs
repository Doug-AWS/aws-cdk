using Aws.Cdk.S3;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    [JsiiInterfaceProxy("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.PipelineProps")]
    public class PipelinePropsProxy : DeputyBase, IPipelineProps
    {
        private PipelinePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The S3 bucket used by this Pipeline to store artifacts.
        /// If not specified, a new S3 bucket will be created.
        /// </summary>
        [JsiiProperty("artifactBucket", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\",\"optional\":true}")]
        public virtual BucketRef ArtifactBucket
        {
            get => GetProperty<BucketRef>();
            set => SetProperty(value);
        }

        /// <summary>Indicates whether to rerun the AWS CodePipeline pipeline after you update it.</summary>
        [JsiiProperty("restartExecutionOnUpdate", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? RestartExecutionOnUpdate
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// Name of the pipeline. If you don't specify a name,  AWS CloudFormation generates an ID
        /// and uses that for the pipeline name.
        /// </summary>
        [JsiiProperty("pipelineName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string PipelineName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}