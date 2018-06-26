using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CodePipeline
{
    /// <summary>
    /// Specifies the constraints on the number of input and output
    /// artifacts an action can have.
    /// 
    /// The constraints for each action type are documented on the
    /// {@link https://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html Pipeline Structure Reference} page.
    /// </summary>
    [JsiiInterface("@aws-cdk/codepipeline", "jsii$_aws_cdk_codepipeline$.ActionArtifactBounds")]
    public interface IActionArtifactBounds
    {
        [JsiiProperty("minInputs", "{\"primitive\":\"number\"}")]
        double MinInputs
        {
            get;
            set;
        }

        [JsiiProperty("maxInputs", "{\"primitive\":\"number\"}")]
        double MaxInputs
        {
            get;
            set;
        }

        [JsiiProperty("minOutputs", "{\"primitive\":\"number\"}")]
        double MinOutputs
        {
            get;
            set;
        }

        [JsiiProperty("maxOutputs", "{\"primitive\":\"number\"}")]
        double MaxOutputs
        {
            get;
            set;
        }
    }
}