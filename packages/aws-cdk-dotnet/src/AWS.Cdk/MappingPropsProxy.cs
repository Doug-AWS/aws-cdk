using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace AWS.Cdk
{
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.MappingProps")]
    public class MappingPropsProxy : DeputyBase, IMappingProps
    {
        private MappingPropsProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("mapping", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}},\"optional\":true}")]
        public virtual IDictionary<string, IDictionary<string, object>> Mapping
        {
            get => GetProperty<IDictionary<string, IDictionary<string, object>>>();
            set => SetProperty(value);
        }
    }
}