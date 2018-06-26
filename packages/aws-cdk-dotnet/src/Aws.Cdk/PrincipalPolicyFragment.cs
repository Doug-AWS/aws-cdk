using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Aws.Cdk
{
    /// <summary>
    /// A collection of the fields in a PolicyStatement that can be used to identify a principal.
    /// 
    /// This consists of the JSON used in the "Principal" field, and optionally a
    /// set of "Condition"s that need to be applied to the policy.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.PrincipalPolicyFragment", "[{\"name\":\"principalJson\",\"type\":{\"primitive\":\"any\"}},{\"name\":\"conditions\",\"type\":{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}},\"optional\":true}}]")]
    public class PrincipalPolicyFragment : DeputyBase
    {
        public PrincipalPolicyFragment(object principalJson, IDictionary<string, object> conditions): base(new DeputyProps(new object[]{principalJson, conditions}))
        {
        }

        protected PrincipalPolicyFragment(ByRefValue reference): base(reference)
        {
        }

        protected PrincipalPolicyFragment(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("principalJson", "{\"primitive\":\"any\"}")]
        public virtual object PrincipalJson
        {
            get => GetProperty<object>();
        }

        [JsiiProperty("conditions", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}")]
        public virtual IDictionary<string, object> Conditions
        {
            get => GetProperty<IDictionary<string, object>>();
        }
    }
}