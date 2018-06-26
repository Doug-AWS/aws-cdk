using AWS.Cdk;
using AWS.Cdk.Events;
using AWS.Cdk.Resources.codecommit;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodeCommit
{
    /// <summary>
    /// Represents a reference to a CodeCommit Repository.
    /// 
    /// If you want to create a new Repository managed alongside your CDK code,
    /// use the {@link Repository} class.
    /// 
    /// If you want to reference an already existing Repository,
    /// use the {@link RepositoryRef.import} method.
    /// </summary>
    [JsiiClass("@aws-cdk/codecommit", "jsii$_aws_cdk_codecommit$.RepositoryRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class RepositoryRef : Construct
    {
        protected RepositoryRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected RepositoryRef(ByRefValue reference): base(reference)
        {
        }

        protected RepositoryRef(DeputyProps props): base(props)
        {
        }

        /// <summary>The ARN of this Repository. </summary>
        [JsiiProperty("repositoryArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.codecommit.RepositoryArn\"}")]
        public virtual RepositoryArn RepositoryArn
        {
            get => GetProperty<RepositoryArn>();
        }

        /// <summary>The human-visible name of this Repository. </summary>
        [JsiiProperty("repositoryName", "{\"fqn\":\"jsii$_aws_cdk_resources$.codecommit.RepositoryName\"}")]
        public virtual RepositoryName RepositoryName
        {
            get => GetProperty<RepositoryName>();
        }

        /// <summary>
        /// Import a Repository defined either outside the CDK, or in a different Stack
        /// (exported with the {@link export} method).
        /// </summary>
        /// <param name = "parent">the parent Construct for the Repository</param>
        /// <param name = "name">the name of the Repository Construct</param>
        /// <param name = "props">the properties used to identify the existing Repository</param>
        /// <returns>a reference to the existing Repository</returns>
        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_codecommit$.RepositoryRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codecommit$.RepositoryRefProps\"}}]")]
        public virtual RepositoryRef Import(Construct parent, string name, IRepositoryRefProps props)
        {
            return InvokeMethod<RepositoryRef>(new object[]{parent, name, props});
        }

        /// <summary>Exports this Repository. Allows the same Repository to be used in 2 different Stacks.</summary>
        /// <remarks>see: import</remarks>
        [JsiiMethod("export", "{\"fqn\":\"jsii$_aws_cdk_codecommit$.RepositoryRefProps\"}", "[]")]
        public virtual IRepositoryRefProps Export()
        {
            return InvokeMethod<IRepositoryRefProps>(new object[]{});
        }

        /// <summary>
        /// Defines a CloudWatch event rule which triggers for repository events. Use
        /// `rule.addEventPattern(pattern)` to specify a filter.
        /// </summary>
        [JsiiMethod("onEvent", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnEvent(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>
        /// Defines a CloudWatch event rule which triggers when a "CodeCommit
        /// Repository State Change" event occurs.
        /// </summary>
        [JsiiMethod("onStateChange", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnStateChange(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>
        /// Defines a CloudWatch event rule which triggers when a reference is
        /// created (i.e. a new brach/tag is created) to the repository.
        /// </summary>
        [JsiiMethod("onReferenceCreated", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnReferenceCreated(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>
        /// Defines a CloudWatch event rule which triggers when a reference is
        /// updated (i.e. a commit is pushed to an existig branch) from the repository.
        /// </summary>
        [JsiiMethod("onReferenceUpdated", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnReferenceUpdated(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>
        /// Defines a CloudWatch event rule which triggers when a reference is
        /// delete (i.e. a branch/tag is deleted) from the repository.
        /// </summary>
        [JsiiMethod("onReferenceDeleted", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnReferenceDeleted(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>Defines a CloudWatch event rule which triggers when a pull request state is changed.</summary>
        [JsiiMethod("onPullRequestStateChange", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnPullRequestStateChange(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>Defines a CloudWatch event rule which triggers when a comment is made on a pull request.</summary>
        [JsiiMethod("onCommentOnPullRequest", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnCommentOnPullRequest(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>Defines a CloudWatch event rule which triggers when a comment is made on a commit.</summary>
        [JsiiMethod("onCommentOnCommit", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnCommentOnCommit(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>Defines a CloudWatch event rule which triggers when a commit is pushed to a branch.</summary>
        /// <param name = "target">The target of the event</param>
        /// <param name = "branch">The branch to monitor. Defaults to all branches.</param>
        [JsiiMethod("onCommit", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"branch\",\"type\":{\"primitive\":\"string\",\"optional\":true}}]")]
        public virtual EventRule OnCommit(string name, IIEventRuleTarget target, string branch)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, branch});
        }
    }
}