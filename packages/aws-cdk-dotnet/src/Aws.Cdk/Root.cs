using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// Represents the root of a construct tree.
    /// No parent and no name.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.Root", "[]")]
    public class Root : Construct
    {
        public Root(): base(new DeputyProps(new object[]{}))
        {
        }

        protected Root(ByRefValue reference): base(reference)
        {
        }

        protected Root(DeputyProps props): base(props)
        {
        }
    }
}