using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace AWS.Cdk.CodeBuild
{
    [JsiiInterfaceProxy("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.BuildEnvironment")]
    public class BuildEnvironmentProxy : DeputyBase, IBuildEnvironment
    {
        private BuildEnvironmentProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The type of build environment. The only allowed value is LINUX_CONTAINER.</summary>
        /// <remarks>default: LINUX_CONTAINER</remarks>
        [JsiiProperty("type", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Type
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>The Docker image identifier that the build environment uses.</summary>
        /// <remarks>
        /// see: https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-available.html
        /// default: aws/codebuild/ubuntu-base:14.04
        /// </remarks>
        [JsiiProperty("image", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Image
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// The type of compute to use for this build. See the
        /// ComputeType enum for options.
        /// </summary>
        /// <remarks>default: ComputeType.Small</remarks>
        [JsiiProperty("computeType", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string ComputeType
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Indicates how the project builds Docker images. Specify true to enable
        /// running the Docker daemon inside a Docker container. This value must be
        /// set to true only if this build project will be used to build Docker
        /// images, and the specified build environment image is not one provided by
        /// AWS CodeBuild with Docker support. Otherwise, all associated builds that
        /// attempt to interact with the Docker daemon will fail.
        /// </summary>
        /// <remarks>default: false</remarks>
        [JsiiProperty("priviledged", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? Priviledged
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }

        /// <summary>The environment variables that your builds can use.</summary>
        [JsiiProperty("environmentVariables", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildEnvironmentVariable\"}},\"optional\":true}")]
        public virtual IDictionary<string, IBuildEnvironmentVariable> EnvironmentVariables
        {
            get => GetProperty<IDictionary<string, IBuildEnvironmentVariable>>();
            set => SetProperty(value);
        }
    }
}