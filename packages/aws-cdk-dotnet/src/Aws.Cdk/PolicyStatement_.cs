using Aws.Cdk.PolicyStatement;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Aws.Cdk
{
    /// <summary>Represents a statement in an IAM policy document.</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.PolicyStatement", "[{\"name\":\"effect\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement.Effect\",\"optional\":true}}]")]
    public class PolicyStatement_ : Token
    {
        public PolicyStatement_(Effect effect): base(new DeputyProps(new object[]{effect}))
        {
        }

        protected PolicyStatement_(ByRefValue reference): base(reference)
        {
        }

        protected PolicyStatement_(DeputyProps props): base(props)
        {
        }

        /// <summary>Indicates if this permission has a "Principal" section.</summary>
        [JsiiProperty("hasPrincipal", "{\"primitive\":\"boolean\"}")]
        public virtual bool HasPrincipal
        {
            get => GetProperty<bool>();
        }

        /// <summary>Indicates if this permission as at least one resource associated with it.</summary>
        [JsiiProperty("hasResource", "{\"primitive\":\"boolean\"}")]
        public virtual bool HasResource
        {
            get => GetProperty<bool>();
        }

        /// <summary>Indicates if this permission has only a ``"*"`` resource associated with it.</summary>
        [JsiiProperty("isOnlyStarResource", "{\"primitive\":\"boolean\"}")]
        public virtual bool IsOnlyStarResource
        {
            get => GetProperty<bool>();
        }

        [JsiiMethod("addAction", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"action\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual PolicyStatement_ AddAction(string action)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{action});
        }

        [JsiiMethod("addActions", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"actions\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual PolicyStatement_ AddActions(string actions)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{actions});
        }

        [JsiiMethod("addPrincipal", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"principal\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyPrincipal\"}}]")]
        public virtual PolicyStatement_ AddPrincipal(PolicyPrincipal principal)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{principal});
        }

        [JsiiMethod("addAwsPrincipal", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"arn\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual PolicyStatement_ AddAwsPrincipal(object arn)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{arn});
        }

        [JsiiMethod("addAwsAccountPrincipal", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"accountId\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual PolicyStatement_ AddAwsAccountPrincipal(object accountId)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{accountId});
        }

        [JsiiMethod("addServicePrincipal", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"service\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual PolicyStatement_ AddServicePrincipal(object service)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{service});
        }

        [JsiiMethod("addFederatedPrincipal", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"federated\",\"type\":{\"primitive\":\"any\"}},{\"name\":\"conditions\",\"type\":{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}}]")]
        public virtual PolicyStatement_ AddFederatedPrincipal(object federated, IDictionary<string, object> conditions)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{federated, conditions});
        }

        [JsiiMethod("addAccountRootPrincipal", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[]")]
        public virtual PolicyStatement_ AddAccountRootPrincipal()
        {
            return InvokeMethod<PolicyStatement_>(new object[]{});
        }

        [JsiiMethod("addResource", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"resource\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual PolicyStatement_ AddResource(object resource)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{resource});
        }

        /// <summary>Adds a ``"*"`` resource to this statement.</summary>
        [JsiiMethod("addAllResources", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[]")]
        public virtual PolicyStatement_ AddAllResources()
        {
            return InvokeMethod<PolicyStatement_>(new object[]{});
        }

        [JsiiMethod("addResources", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"resources\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual PolicyStatement_ AddResources(object resources)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{resources});
        }

        [JsiiMethod("describe", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"sid\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual PolicyStatement_ Describe(object sid)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{sid});
        }

        /// <summary>Sets the permission effect to deny access to resources.</summary>
        [JsiiMethod("allow", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[]")]
        public virtual PolicyStatement_ Allow()
        {
            return InvokeMethod<PolicyStatement_>(new object[]{});
        }

        /// <summary>Sets the permission effect to allow access to resources.</summary>
        [JsiiMethod("deny", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[]")]
        public virtual PolicyStatement_ Deny()
        {
            return InvokeMethod<PolicyStatement_>(new object[]{});
        }

        /// <summary>Add a condition to the Policy</summary>
        [JsiiMethod("addCondition", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"value\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual PolicyStatement_ AddCondition(string key, object value)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{key, value});
        }

        /// <summary>Add multiple conditions to the Policy</summary>
        [JsiiMethod("addConditions", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"conditions\",\"type\":{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}}]")]
        public virtual PolicyStatement_ AddConditions(IDictionary<string, object> conditions)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{conditions});
        }

        /// <summary>Add a condition to the Policy.</summary>
        /// <remarks>deprecated: For backwards compatibility. Use addCondition() instead.</remarks>
        [JsiiMethod("setCondition", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"value\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual PolicyStatement_ SetCondition(string key, object value)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{key, value});
        }

        [JsiiMethod("limitToAccount", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}", "[{\"name\":\"accountId\",\"type\":{\"primitive\":\"any\"}}]")]
        public virtual PolicyStatement_ LimitToAccount(object accountId)
        {
            return InvokeMethod<PolicyStatement_>(new object[]{accountId});
        }

        [JsiiMethod("resolve", "{\"primitive\":\"any\"}", "[]")]
        public override object Resolve()
        {
            return InvokeMethod<object>(new object[]{});
        }

        [JsiiMethod("toJson", "{\"primitive\":\"any\"}", "[]")]
        public virtual object ToJson()
        {
            return InvokeMethod<object>(new object[]{});
        }
    }
}