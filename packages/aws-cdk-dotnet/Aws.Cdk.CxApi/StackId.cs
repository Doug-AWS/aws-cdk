using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CxApi
{
    /// <summary>Identifies a single stack</summary>
    public class StackId : DeputyBase, IStackId
    {
        [JsiiProperty("name", "{\"primitive\":\"string\"}", true)]
        public string Name
        {
            get;
            set;
        }
    }
}