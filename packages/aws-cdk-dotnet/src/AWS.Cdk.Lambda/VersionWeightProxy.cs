using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Lambda
{
    /// <summary>A version/weight pair for routing traffic to Lambda functions</summary>
    [JsiiInterfaceProxy("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.VersionWeight")]
    public class VersionWeightProxy : DeputyBase, IVersionWeight
    {
        private VersionWeightProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The version to route traffic to</summary>
        [JsiiProperty("version", "{\"fqn\":\"jsii$_aws_cdk_lambda$.Version\"}")]
        public virtual Version Version
        {
            get => GetProperty<Version>();
        }

        /// <summary>How much weight to assign to this version (0..1)</summary>
        [JsiiProperty("weight", "{\"primitive\":\"number\"}")]
        public virtual double Weight
        {
            get => GetProperty<double>();
        }
    }
}