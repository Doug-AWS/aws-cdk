using Aws.Cdk.Iam;
using Aws.Cdk.Kms;
using Aws.Cdk.S3;
using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Aws.Cdk.CodeBuild
{
    [JsiiInterfaceProxy("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.BuildProjectProps")]
    public class BuildProjectPropsProxy : DeputyBase, IBuildProjectProps
    {
        private BuildProjectPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The source of the build.</summary>
        [JsiiProperty("source", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildSource\"}")]
        public virtual BuildSource Source
        {
            get => GetProperty<BuildSource>();
            set => SetProperty(value);
        }

        /// <summary>
        /// A description of the project. Use the description to identify the purpose
        /// of the project.
        /// </summary>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Description
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Filename or contents of buildspec in JSON format.</summary>
        /// <remarks>see: https://docs.aws.amazon.com/codebuild/latest/userguide/build-spec-ref.html#build-spec-ref-example</remarks>
        [JsiiProperty("buildSpec", "{\"primitive\":\"json\",\"optional\":true}")]
        public virtual JObject BuildSpec
        {
            get => GetProperty<JObject>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Service Role to assume while running the build.
        /// If not specified, a role will be created.
        /// </summary>
        [JsiiProperty("role", "{\"fqn\":\"jsii$_aws_cdk_iam$.Role\",\"optional\":true}")]
        public virtual Role Role
        {
            get => GetProperty<Role>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Encryption key to use to read and write artifacts
        /// If not specified, a role will be created.
        /// </summary>
        [JsiiProperty("encryptionKey", "{\"fqn\":\"jsii$_aws_cdk_kms$.EncryptionKeyRef\",\"optional\":true}")]
        public virtual EncryptionKeyRef EncryptionKey
        {
            get => GetProperty<EncryptionKeyRef>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Bucket to store cached source artifacts
        /// If not specified, source artifacts will not be cached.
        /// </summary>
        [JsiiProperty("cacheBucket", "{\"fqn\":\"jsii$_aws_cdk_s3$.BucketRef\",\"optional\":true}")]
        public virtual BucketRef CacheBucket
        {
            get => GetProperty<BucketRef>();
            set => SetProperty(value);
        }

        /// <summary>Subdirectory to store cached artifacts</summary>
        [JsiiProperty("cacheDir", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string CacheDir
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Build environment to use for the build.</summary>
        [JsiiProperty("environment", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildEnvironment\",\"optional\":true}")]
        public virtual IBuildEnvironment Environment
        {
            get => GetProperty<IBuildEnvironment>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Indicates whether AWS CodeBuild generates a publicly accessible URL for
        /// your project's build badge. For more information, see Build Badges Sample
        /// in the AWS CodeBuild User Guide.
        /// </summary>
        [JsiiProperty("badge", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? Badge
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// The number of minutes after which AWS CodeBuild stops the build if it's
        /// not complete. For valid values, see the timeoutInMinutes field in the AWS
        /// CodeBuild User Guide.
        /// </summary>
        [JsiiProperty("timeout", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? Timeout
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// Defines where build artifacts will be stored.
        /// Could be: PipelineBuildArtifacts, NoBuildArtifacts and S3BucketBuildArtifacts.
        /// </summary>
        /// <remarks>default: NoBuildArtifacts</remarks>
        [JsiiProperty("artifacts", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildArtifacts\",\"optional\":true}")]
        public virtual BuildArtifacts Artifacts
        {
            get => GetProperty<BuildArtifacts>();
            set => SetProperty(value);
        }

        /// <summary>Additional environment variables to add to the build environment.</summary>
        [JsiiProperty("environmentVariables", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildEnvironmentVariable\"}},\"optional\":true}")]
        public virtual IDictionary<string, IBuildEnvironmentVariable> EnvironmentVariables
        {
            get => GetProperty<IDictionary<string, IBuildEnvironmentVariable>>();
            set => SetProperty(value);
        }
    }
}