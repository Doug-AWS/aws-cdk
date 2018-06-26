using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodePipeline
{
    /// <summary>
    /// Specifies the constraints on the number of input and output
    /// artifacts an action can have.
    /// 
    /// The constraints for each action type are documented on the
    /// {@link https://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html Pipeline Structure Reference} page.
    /// </summary>
    [JsiiInterfaceProxy("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.ActionArtifactBounds")]
    public class ActionArtifactBoundsProxy : DeputyBase, IActionArtifactBounds
    {
        private ActionArtifactBoundsProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("minInputs", "{\"primitive\":\"number\"}")]
        public virtual double MinInputs
        {
            get => GetProperty<double>();
            set => SetProperty(value);
        }

        [JsiiProperty("maxInputs", "{\"primitive\":\"number\"}")]
        public virtual double MaxInputs
        {
            get => GetProperty<double>();
            set => SetProperty(value);
        }

        [JsiiProperty("minOutputs", "{\"primitive\":\"number\"}")]
        public virtual double MinOutputs
        {
            get => GetProperty<double>();
            set => SetProperty(value);
        }

        [JsiiProperty("maxOutputs", "{\"primitive\":\"number\"}")]
        public virtual double MaxOutputs
        {
            get => GetProperty<double>();
            set => SetProperty(value);
        }
    }
}