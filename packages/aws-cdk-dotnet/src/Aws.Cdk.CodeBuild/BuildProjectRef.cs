using Aws.Cdk;
using Aws.Cdk.Events;
using Aws.Cdk.Iam;
using Aws.Cdk.Resources.codebuild;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodeBuild
{
    /// <summary>
    /// Represents a reference to a CodeBuild Project.
    /// 
    /// If you're managing the Project alongside the rest of your CDK resources,
    /// use the {@link BuildProject} class.
    /// 
    /// If you want to reference an already existing Project
    /// (or one defined in a different CDK Stack),
    /// use the {@link import} method.
    /// </summary>
    [JsiiClass("@aws-cdk/codebuild", "jsii$_aws_cdk_codebuild$.BuildProjectRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class BuildProjectRef : Construct, IIEventRuleTarget
    {
        protected BuildProjectRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected BuildProjectRef(ByRefValue reference): base(reference)
        {
        }

        protected BuildProjectRef(DeputyProps props): base(props)
        {
        }

        /// <summary>The ARN of this Project. </summary>
        [JsiiProperty("projectArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.codebuild.ProjectArn\"}")]
        public virtual ProjectArn ProjectArn
        {
            get => GetProperty<ProjectArn>();
        }

        /// <summary>The human-visible name of this Project. </summary>
        [JsiiProperty("projectName", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.ProjectName\"}")]
        public virtual ProjectName ProjectName
        {
            get => GetProperty<ProjectName>();
        }

        /// <summary>The IAM service Role of this Project. Undefined for imported Projects. </summary>
        [JsiiProperty("role", "{\"fqn\":\"jsii$_aws_cdk_iam$.Role\",\"optional\":true}")]
        public virtual Role Role
        {
            get => GetProperty<Role>();
        }

        /// <summary>Allows using build projects as event rule targets.</summary>
        [JsiiProperty("eventRuleTarget", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleTarget\"}")]
        public virtual IEventRuleTarget EventRuleTarget
        {
            get => GetProperty<IEventRuleTarget>();
        }

        /// <summary>
        /// Import a Project defined either outside the CDK,
        /// or in a different CDK Stack
        /// (and exported using the {@link export} method).
        /// </summary>
        /// <param name = "parent">the parent Construct for this Construct</param>
        /// <param name = "name">the logical name of this Construct</param>
        /// <param name = "props">the properties of the referenced Project</param>
        /// <returns>a reference to the existing Project</returns>
        /// <remarks>
        /// note: if you're importing a CodeBuild Project for use
        /// in a CodePipeline, make sure the existing Project
        /// has permissions to access the S3 Bucket of that Pipeline -
        /// otherwise, builds in that Pipeline will always fail.
        /// </remarks>
        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildProjectRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildProjectRefProps\"}}]")]
        public virtual BuildProjectRef Import(Construct parent, string name, IBuildProjectRefProps props)
        {
            return InvokeMethod<BuildProjectRef>(new object[]{parent, name, props});
        }

        /// <summary>Export this Project. Allows referencing this Project in a different CDK Stack.</summary>
        [JsiiMethod("export", "{\"fqn\":\"jsii$_aws_cdk_codebuild$.BuildProjectRefProps\"}", "[]")]
        public virtual IBuildProjectRefProps Export()
        {
            return InvokeMethod<IBuildProjectRefProps>(new object[]{});
        }

        /// <summary>
        /// Defines a CloudWatch event rule triggered when the build project state
        /// changes. You can filter specific build status events using an event
        /// pattern filter on the `build-status` detail field:
        /// 
        ///       const rule = project.onStateChange('OnBuildStarted', target);
        ///       rule.addEventPattern({
        ///           detail: {
        ///               'build-status': [
        ///                   "IN_PROGRESS",
        ///                   "SUCCEEDED",
        ///                   "FAILED",
        ///                   "STOPPED"
        ///               ]
        ///           }
        ///       });
        /// 
        /// You can also use the methods `onBuildFailed` and `onBuildSucceeded` to define rules for
        /// these specific state changes.
        /// </summary>
        /// <remarks>see: https://docs.aws.amazon.com/codebuild/latest/userguide/sample-build-notifications.html</remarks>
        [JsiiMethod("onStateChange", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnStateChange(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>
        /// Defines a CloudWatch event rule that triggers upon phase change of this
        /// build project.
        /// </summary>
        /// <remarks>see: https://docs.aws.amazon.com/codebuild/latest/userguide/sample-build-notifications.html</remarks>
        [JsiiMethod("onPhaseChange", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnPhaseChange(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>Defines an event rule which triggers when a build starts.</summary>
        [JsiiMethod("onBuildStarted", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnBuildStarted(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>Defines an event rule which triggers when a build fails.</summary>
        [JsiiMethod("onBuildFailed", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnBuildFailed(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>Defines an event rule which triggers when a build completes successfully.</summary>
        [JsiiMethod("onBuildSucceeded", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnBuildSucceeded(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }
    }
}