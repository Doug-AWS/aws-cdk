using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    public class ConditionProps : DeputyBase, IConditionProps
    {
        [JsiiProperty("expression", "{\"fqn\":\"jsii$_aws_cdk_core$.FnCondition\",\"optional\":true}", true)]
        public FnCondition Expression
        {
            get;
            set;
        }
    }
}