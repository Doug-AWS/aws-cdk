using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.ConditionProps")]
    public class ConditionPropsProxy : DeputyBase, IConditionProps
    {
        private ConditionPropsProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("expression", "{\"fqn\":\"jsii$_aws_cdk_core$.FnCondition\",\"optional\":true}")]
        public virtual FnCondition Expression
        {
            get => GetProperty<FnCondition>();
            set => SetProperty(value);
        }
    }
}