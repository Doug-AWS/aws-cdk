using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Lambda
{
    /// <summary>A version/weight pair for routing traffic to Lambda functions</summary>
    public class VersionWeight : DeputyBase, IVersionWeight
    {
        /// <summary>The version to route traffic to</summary>
        [JsiiProperty("version", "{\"fqn\":\"jsii$_aws_cdk_lambda$.Version\"}", true)]
        public Version Version
        {
            get;
        }

        /// <summary>How much weight to assign to this version (0..1)</summary>
        [JsiiProperty("weight", "{\"primitive\":\"number\"}", true)]
        public double Weight
        {
            get;
        }
    }
}