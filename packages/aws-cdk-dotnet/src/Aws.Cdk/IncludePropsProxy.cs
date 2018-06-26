using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;

namespace Aws.Cdk
{
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.IncludeProps")]
    public class IncludePropsProxy : DeputyBase, IIncludeProps
    {
        private IncludePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The CloudFormation template to include in the stack (as is).</summary>
        [JsiiProperty("template", "{\"primitive\":\"json\"}")]
        public virtual JObject Template
        {
            get => GetProperty<JObject>();
            set => SetProperty(value);
        }
    }
}