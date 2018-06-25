using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.AccountPrincipal", "[{\"name\":\"accountId\",\"type\":{\"primitive\":\"any\"}}]")]
    public class AccountPrincipal : ArnPrincipal
    {
        public AccountPrincipal(object accountId): base(new DeputyProps(new object[]{accountId}))
        {
        }

        protected AccountPrincipal(ByRefValue reference): base(reference)
        {
        }

        protected AccountPrincipal(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("accountId", "{\"primitive\":\"any\"}")]
        public virtual object AccountId
        {
            get => GetProperty<object>();
        }
    }
}