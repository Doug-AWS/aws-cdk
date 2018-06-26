using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.PolicyDocument", "[{\"name\":\"baseDocument\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class PolicyDocument : Token
    {
        public PolicyDocument(object baseDocument): base(new DeputyProps(new object[]{baseDocument}))
        {
        }

        protected PolicyDocument(ByRefValue reference): base(reference)
        {
        }

        protected PolicyDocument(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("isEmpty", "{\"primitive\":\"boolean\"}")]
        public virtual bool IsEmpty
        {
            get => GetProperty<bool>();
        }

        /// <summary>
        /// The number of statements already added to this policy.
        /// Can be used, for example, to generate uniuqe "sid"s within the policy.
        /// </summary>
        [JsiiProperty("statementCount", "{\"primitive\":\"number\"}")]
        public virtual double StatementCount
        {
            get => GetProperty<double>();
        }

        [JsiiMethod("resolve", "{\"primitive\":\"any\"}", "[]")]
        public override object Resolve()
        {
            return InvokeMethod<object>(new object[]{});
        }

        [JsiiMethod("addStatement", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyDocument\"}", "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual PolicyDocument AddStatement(PolicyStatement_ statement)
        {
            return InvokeMethod<PolicyDocument>(new object[]{statement});
        }
    }
}