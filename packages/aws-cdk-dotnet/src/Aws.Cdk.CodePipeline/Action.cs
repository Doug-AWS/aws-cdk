using Aws.Cdk;
using Aws.Cdk.Events;
using Aws.Cdk.Resources.codepipeline.PipelineResource;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <summary>
    /// Low level class for generically creating pipeline actions.
    /// It is recommended that concrete types are used instead, such as {@link CodeCommitSource} or
    /// {@link CodeBuildAction}.
    /// </summary>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.Action", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Stage\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.ActionProps\"}}]")]
    public abstract class Action : Construct
    {
        protected Action(Stage parent, string name, IActionProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Action(ByRefValue reference): base(reference)
        {
        }

        protected Action(DeputyProps props): base(props)
        {
        }

        /// <summary>The category of the action. The category defines which action type the owner (the entity that performs the action) performs.</summary>
        [JsiiProperty("category", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.ActionCategory\"}")]
        public virtual ActionCategory Category
        {
            get => GetProperty<ActionCategory>();
        }

        /// <summary>The service provider that the action calls.</summary>
        [JsiiProperty("provider", "{\"primitive\":\"string\"}")]
        public virtual string Provider
        {
            get => GetProperty<string>();
        }

        /// <summary>
        /// The action's configuration. These are key-value pairs that specify input values for an action.
        /// For more information, see the AWS CodePipeline User Guide.
        /// 
        /// http://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#action-requirements
        /// </summary>
        [JsiiProperty("configuration", "{\"primitive\":\"any\",\"optional\":true}")]
        public virtual object Configuration
        {
            get => GetProperty<object>();
        }

        /// <summary>
        /// The order in which AWS CodePipeline runs this action.
        /// For more information, see the AWS CodePipeline User Guide.
        /// 
        /// https://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#action-requirements
        /// </summary>
        [JsiiProperty("runOrder", "{\"primitive\":\"number\"}")]
        public virtual double RunOrder
        {
            get => GetProperty<double>();
            set => SetProperty(value);
        }

        /// <summary>
        /// This method can be implemented by derived constructs in order to perform
        /// validation logic. It is called on all constructs before synthesis.
        /// </summary>
        [JsiiMethod("validate", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}", "[]")]
        public override string[] Validate()
        {
            return InvokeMethod<string[]>(new object[]{});
        }

        /// <summary>Render the Action to a CloudFormation struct</summary>
        [JsiiMethod("render", "{\"fqn\":\"jsii$_aws_cdk_resources$.codepipeline.PipelineResource.ActionDeclarationProperty\"}", "[]")]
        public virtual IActionDeclarationProperty Render()
        {
            return InvokeMethod<IActionDeclarationProperty>(new object[]{});
        }

        [JsiiMethod("onStateChange", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnStateChange(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>If an Artifact is added as a child, add it to the list of output artifacts.</summary>
        [JsiiMethod("addChild", null, "[{\"name\":\"child\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
        protected override void AddChild(Construct child, string name)
        {
            InvokeVoidMethod(new object[]{child, name});
        }

        [JsiiMethod("addOutputArtifact", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
        protected virtual Artifact AddOutputArtifact(string name)
        {
            return InvokeMethod<Artifact>(new object[]{name});
        }

        [JsiiMethod("addInputArtifact", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Action\"}", "[{\"name\":\"artifact\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Artifact\"}}]")]
        protected virtual Action AddInputArtifact(Artifact artifact)
        {
            return InvokeMethod<Action>(new object[]{artifact});
        }
    }
}