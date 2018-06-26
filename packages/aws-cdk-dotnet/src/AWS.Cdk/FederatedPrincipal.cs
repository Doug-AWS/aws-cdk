using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace AWS.Cdk
{
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FederatedPrincipal", "[{\"name\":\"federated\",\"type\":{\"primitive\":\"any\"}},{\"name\":\"conditions\",\"type\":{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}},{\"name\":\"assumeRoleAction\",\"type\":{\"primitive\":\"string\",\"optional\":true}}]")]
    public class FederatedPrincipal : PolicyPrincipal
    {
        public FederatedPrincipal(object federated, IDictionary<string, object> conditions, string assumeRoleAction): base(new DeputyProps(new object[]{federated, conditions, assumeRoleAction}))
        {
        }

        protected FederatedPrincipal(ByRefValue reference): base(reference)
        {
        }

        protected FederatedPrincipal(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("federated", "{\"primitive\":\"any\"}")]
        public virtual object Federated
        {
            get => GetProperty<object>();
        }

        [JsiiProperty("conditions", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}")]
        public virtual IDictionary<string, object> Conditions
        {
            get => GetProperty<IDictionary<string, object>>();
        }

        [JsiiProperty("assumeRoleAction", "{\"primitive\":\"string\"}")]
        public override string AssumeRoleAction
        {
            get => GetProperty<string>();
        }

        /// <summary>Return the policy fragment that identifies this principal in a Policy.</summary>
        [JsiiMethod("policyFragment", "{\"fqn\":\"jsii$_aws_cdk_core$.PrincipalPolicyFragment\"}", "[]")]
        public override PrincipalPolicyFragment PolicyFragment()
        {
            return InvokeMethod<PrincipalPolicyFragment>(new object[]{});
        }
    }
}