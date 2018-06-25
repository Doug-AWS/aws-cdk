using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CxApi
{
    [JsiiInterfaceProxy("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.SynthesizeResponse")]
    public class SynthesizeResponseProxy : DeputyBase, ISynthesizeResponse
    {
        private SynthesizeResponseProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("stacks", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.SynthesizedStack\"}}}")]
        public virtual ISynthesizedStack[] Stacks
        {
            get => GetProperty<ISynthesizedStack[]>();
            set => SetProperty(value);
        }
    }
}