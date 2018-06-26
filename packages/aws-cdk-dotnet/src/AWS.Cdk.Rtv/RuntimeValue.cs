using AWS.Cdk;
using AWS.Cdk.Iam;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Rtv
{
    [JsiiClass("@aws-cdk/rtv", "jsii$_aws_cdk_rtv$.RuntimeValue", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_rtv$.RuntimeValueProps\"}}]")]
    public class RuntimeValue : Construct
    {
        public RuntimeValue(Construct parent, string name, IRuntimeValueProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected RuntimeValue(ByRefValue reference): base(reference)
        {
        }

        protected RuntimeValue(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("ENV_NAME", "{\"primitive\":\"string\"}")]
        public virtual string ENV_NAME
        {
            get => GetProperty<string>();
        }

        [JsiiProperty("ENV_VALUE", "{\"fqn\":\"jsii$_aws_cdk_core$.AwsStackName\"}")]
        public virtual AwsStackName ENV_VALUE
        {
            get => GetProperty<AwsStackName>();
        }

        [JsiiProperty("parameterName", "{\"primitive\":\"any\"}")]
        public virtual object ParameterName
        {
            get => GetProperty<object>();
        }

        [JsiiProperty("arn", "{\"fqn\":\"jsii$_aws_cdk_core$.Arn\"}")]
        public virtual Arn Arn
        {
            get => GetProperty<Arn>();
        }

        [JsiiMethod("grantReadPermissions", null, "[{\"name\":\"principal\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.IIdentityResource\"}}]")]
        public virtual void GrantReadPermissions(IIIdentityResource principal)
        {
            InvokeVoidMethod(new object[]{principal});
        }
    }
}