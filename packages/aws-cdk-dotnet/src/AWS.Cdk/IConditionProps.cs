using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    [JsiiInterface("@aws-cdk/core", "jsii$_aws_cdk_core$.ConditionProps")]
    public interface IConditionProps
    {
        [JsiiProperty("expression", "{\"fqn\":\"jsii$_aws_cdk_core$.FnCondition\",\"optional\":true}")]
        FnCondition Expression
        {
            get;
            set;
        }
    }
}