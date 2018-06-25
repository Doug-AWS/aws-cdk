using Aws.Cdk;
using Aws.Cdk.Events;
using Aws.Cdk.Resources.codepipeline.PipelineResource;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <summary>
    /// A stage in a pipeline. Stages are added to a pipeline by constructing a Stage with
    /// the pipeline as the first argument to the constructor.
    /// </summary>
    /// <remarks>
    /// example: // add a stage to a pipeline
    /// new Stage(pipeline, 'MyStage');
    /// </remarks>
    [JsiiClass("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.Stage", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Pipeline\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Stage : Construct
    {
        public Stage(Pipeline parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected Stage(ByRefValue reference): base(reference)
        {
        }

        protected Stage(DeputyProps props): base(props)
        {
        }

        /// <summary>The Pipeline this stage is a member of</summary>
        [JsiiProperty("pipeline", "{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Pipeline\"}")]
        public virtual Pipeline Pipeline
        {
            get => GetProperty<Pipeline>();
        }

        /// <summary>Get a duplicate of this stage's list of actions.</summary>
        [JsiiProperty("actions", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_codepipeline$.Action\"}}}")]
        public virtual Action[] Actions
        {
            get => GetProperty<Action[]>();
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

        [JsiiMethod("render", "{\"fqn\":\"jsii$_aws_cdk_resources$.codepipeline.PipelineResource.StageDeclarationProperty\"}", "[]")]
        public virtual IStageDeclarationProperty Render()
        {
            return InvokeMethod<IStageDeclarationProperty>(new object[]{});
        }

        [JsiiMethod("onStateChange", "{\"fqn\":\"jsii$_aws_cdk_events$.EventRule\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"target\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.IEventRuleTarget\",\"optional\":true}},{\"name\":\"options\",\"type\":{\"fqn\":\"jsii$_aws_cdk_events$.EventRuleProps\",\"optional\":true}}]")]
        public virtual EventRule OnStateChange(string name, IIEventRuleTarget target, IEventRuleProps options)
        {
            return InvokeMethod<EventRule>(new object[]{name, target, options});
        }

        /// <summary>
        /// If an action is added as a child, add it to the list of actions.
        /// TODO: This is a hack that should be removed once the CDK has an
        ///        onChildAdded type hook.
        /// </summary>
        /// <remarks>override: </remarks>
        [JsiiMethod("addChild", null, "[{\"name\":\"child\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
        protected override void AddChild(Construct child, string name)
        {
            InvokeVoidMethod(new object[]{child, name});
        }
    }
}