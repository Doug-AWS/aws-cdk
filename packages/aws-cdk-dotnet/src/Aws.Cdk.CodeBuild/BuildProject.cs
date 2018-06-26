using Aws.Cdk;
using Aws.Cdk.Iam;
using Aws.Cdk.Resources.codebuild;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    /// <summary>
    /// A CodeBuild project that is completely driven
    /// from CodePipeline (does not hot have its own input or output)
    /// </summary>
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.BuildProject", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildProjectProps\"}}]")]
    public class BuildProject : BuildProjectRef
    {
        public BuildProject(Construct parent, string name, IBuildProjectProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected BuildProject(ByRefValue reference): base(reference)
        {
        }

        protected BuildProject(DeputyProps props): base(props)
        {
        }

        /// <summary>The IAM role for this project.</summary>
        [JsiiProperty("role", "{\"fqn\":\"jsii$_aws_cdk_iam$.Role\"}")]
        public override Role Role
        {
            get => GetProperty<Role>();
        }

        /// <summary>The ARN of the project.</summary>
        [JsiiProperty("projectArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.codebuild.ProjectArn\"}")]
        public override ProjectArn ProjectArn
        {
            get => GetProperty<ProjectArn>();
        }

        /// <summary>The name of the project.</summary>
        [JsiiProperty("projectName", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.ProjectName\"}")]
        public override ProjectName ProjectName
        {
            get => GetProperty<ProjectName>();
        }

        /// <summary>Add a permission only if there's a policy attached.</summary>
        /// <param name = "statement">The permissions statement to add</param>
        [JsiiMethod("addToRolePolicy", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddToRolePolicy(PolicyStatement statement)
        {
            InvokeVoidMethod(new object[]{statement});
        }
    }
}