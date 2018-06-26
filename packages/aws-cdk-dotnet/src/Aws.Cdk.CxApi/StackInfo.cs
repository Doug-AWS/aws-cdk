using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CxApi
{
    /// <summary>Identifies and contains metadata about a stack</summary>
    public class StackInfo : DeputyBase, IStackInfo
    {
        [JsiiProperty("environment", "{\"fqn\":\"jsii$_aws_cdk_cx_api$.Environment\",\"optional\":true}", true)]
        public IEnvironment Environment
        {
            get;
            set;
        }

        [JsiiProperty("name", "{\"primitive\":\"string\"}", true)]
        public string Name
        {
            get;
            set;
        }
    }
}