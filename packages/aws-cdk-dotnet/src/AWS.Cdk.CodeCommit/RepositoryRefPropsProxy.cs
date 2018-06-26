using AWS.Cdk.Resources.codecommit;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodeCommit
{
    /// <summary>Properties for the {@link RepositoryRef.import} method.</summary>
    [JsiiInterfaceProxy("@aws-cdk/codecommit", "jsii$_aws_cdk_codecommit$.RepositoryRefProps")]
    public class RepositoryRefPropsProxy : DeputyBase, IRepositoryRefProps
    {
        private RepositoryRefPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The name of an existing CodeCommit Repository that we are referencing.
        /// Must be in the same account and region as the root Stack.
        /// </summary>
        [JsiiProperty("repositoryName", "{\"fqn\":\"jsii$_aws_cdk_resources$.codecommit.RepositoryName\"}")]
        public virtual RepositoryName RepositoryName
        {
            get => GetProperty<RepositoryName>();
            set => SetProperty(value);
        }
    }
}