using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;

namespace Aws.Cdk
{
    [JsiiInterface("@aws-cdk/core", "jsii$_aws_cdk_core$.IncludeProps")]
    public interface IIncludeProps
    {
        /// <summary>The CloudFormation template to include in the stack (as is).</summary>
        [JsiiProperty("template", "{\"primitive\":\"json\"}")]
        JObject Template
        {
            get;
            set;
        }
    }
}