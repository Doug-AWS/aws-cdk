using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CxApi
{
    [JsiiInterfaceProxy("@aws-cdk/cx-api", "jsii$_aws_cdk_cx_api$.ListStacksResponse")]
    public class ListStacksResponseProxy : DeputyBase, IListStacksResponse
    {
        private ListStacksResponseProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("stacks", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cx_api$.StackInfo\"}}}")]
        public virtual IStackInfo[] Stacks
        {
            get => GetProperty<IStackInfo[]>();
            set => SetProperty(value);
        }
    }
}