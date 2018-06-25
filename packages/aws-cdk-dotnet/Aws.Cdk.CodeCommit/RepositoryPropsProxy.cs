using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeCommit
{
    [JsiiInterfaceProxy("@aws-cdk/codecommit", "jsii$_aws_cdk_codecommit$.RepositoryProps")]
    public class RepositoryPropsProxy : DeputyBase, IRepositoryProps
    {
        private RepositoryPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Name of the repository. This property is required for all repositories.</summary>
        [JsiiProperty("repositoryName", "{\"primitive\":\"string\"}")]
        public virtual string RepositoryName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// A description of the repository. Use the description to identify the
        /// purpose of the repository.
        /// </summary>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Description
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}