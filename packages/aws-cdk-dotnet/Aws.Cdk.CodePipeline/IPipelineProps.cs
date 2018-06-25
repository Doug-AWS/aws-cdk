using Aws.Cdk.S3;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    [JsiiInterface("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.PipelineProps")]
    public interface IPipelineProps
    {
        /// <summary>
        /// The S3 bucket used by this Pipeline to store artifacts.
        /// If not specified, a new S3 bucket will be created.
        /// </summary>
        [JsiiProperty("artifactBucket", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\",\"optional\":true}")]
        BucketRef ArtifactBucket
        {
            get;
            set;
        }

        /// <summary>Indicates whether to rerun the AWS CodePipeline pipeline after you update it.</summary>
        [JsiiProperty("restartExecutionOnUpdate", "{\"primitive\":\"boolean\",\"optional\":true}")]
        bool? RestartExecutionOnUpdate
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the pipeline. If you don't specify a name,  AWS CloudFormation generates an ID
        /// and uses that for the pipeline name.
        /// </summary>
        [JsiiProperty("pipelineName", "{\"primitive\":\"string\",\"optional\":true}")]
        string PipelineName
        {
            get;
            set;
        }
    }
}