using Aws.Cdk.Iam;
using Aws.Cdk.Kms;
using Aws.Cdk.S3;
using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Aws.Cdk.CodeBuild
{
    [JsiiInterface("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.BuildProjectProps")]
    public interface IBuildProjectProps
    {
        /// <summary>The source of the build.</summary>
        [JsiiProperty("source", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildSource\"}")]
        BuildSource Source
        {
            get;
            set;
        }

        /// <summary>
        /// A description of the project. Use the description to identify the purpose
        /// of the project.
        /// </summary>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        string Description
        {
            get;
            set;
        }

        /// <summary>Filename or contents of buildspec in JSON format.</summary>
        /// <remarks>see: https://docs.aws.amazon.com/codebuild/latest/userguide/build-spec-ref.html#build-spec-ref-example</remarks>
        [JsiiProperty("buildSpec", "{\"primitive\":\"json\",\"optional\":true}")]
        JObject BuildSpec
        {
            get;
            set;
        }

        /// <summary>
        /// Service Role to assume while running the build.
        /// If not specified, a role will be created.
        /// </summary>
        [JsiiProperty("role", "{\"fqn\":\"jsii$_aws_cdk_iam$.Role\",\"optional\":true}")]
        Role Role
        {
            get;
            set;
        }

        /// <summary>
        /// Encryption key to use to read and write artifacts
        /// If not specified, a role will be created.
        /// </summary>
        [JsiiProperty("encryptionKey", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRef\",\"optional\":true}")]
        EncryptionKeyRef EncryptionKey
        {
            get;
            set;
        }

        /// <summary>
        /// Bucket to store cached source artifacts
        /// If not specified, source artifacts will not be cached.
        /// </summary>
        [JsiiProperty("cacheBucket", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\",\"optional\":true}")]
        BucketRef CacheBucket
        {
            get;
            set;
        }

        /// <summary>Subdirectory to store cached artifacts</summary>
        [JsiiProperty("cacheDir", "{\"primitive\":\"string\",\"optional\":true}")]
        string CacheDir
        {
            get;
            set;
        }

        /// <summary>Build environment to use for the build.</summary>
        [JsiiProperty("environment", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildEnvironment\",\"optional\":true}")]
        IBuildEnvironment Environment
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates whether AWS CodeBuild generates a publicly accessible URL for
        /// your project's build badge. For more information, see Build Badges Sample
        /// in the AWS CodeBuild User Guide.
        /// </summary>
        [JsiiProperty("badge", "{\"primitive\":\"boolean\",\"optional\":true}")]
        bool? Badge
        {
            get;
            set;
        }

        /// <summary>
        /// The number of minutes after which AWS CodeBuild stops the build if it's
        /// not complete. For valid values, see the timeoutInMinutes field in the AWS
        /// CodeBuild User Guide.
        /// </summary>
        [JsiiProperty("timeout", "{\"primitive\":\"number\",\"optional\":true}")]
        double? Timeout
        {
            get;
            set;
        }

        /// <summary>
        /// Defines where build artifacts will be stored.
        /// Could be: PipelineBuildArtifacts, NoBuildArtifacts and S3BucketBuildArtifacts.
        /// </summary>
        /// <remarks>default: NoBuildArtifacts</remarks>
        [JsiiProperty("artifacts", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildArtifacts\",\"optional\":true}")]
        BuildArtifacts Artifacts
        {
            get;
            set;
        }

        /// <summary>Additional environment variables to add to the build environment.</summary>
        [JsiiProperty("environmentVariables", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildEnvironmentVariable\"}},\"optional\":true}")]
        IDictionary<string, IBuildEnvironmentVariable> EnvironmentVariables
        {
            get;
            set;
        }
    }
}