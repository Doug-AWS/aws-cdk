using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// Defines a secret value resolved from the Systems Manager (SSM) Parameter
    /// Store during deployment. This is useful for referencing values that you do
    /// not wish to include in your code base, such as secrets, passwords and keys.
    /// 
    /// This construct will add a CloudFormation parameter to your template bound to
    /// an SSM parameter (of type "AWS::SSM::Parameter::Value&lt;String&gt;"). Deployment
    /// will fail if the value doesn't exist in the target environment.
    /// 
    /// Important: For values other than secrets, prefer to use the
    /// `SSMParameterProvider` which resolves SSM parameter in design-time, and
    /// ensures that stack deployments are deterministic.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.SecretParameter", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.SecretProps\"}}]")]
    public class SecretParameter : Construct
    {
        public SecretParameter(Construct parent, string name, ISecretProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected SecretParameter(ByRefValue reference): base(reference)
        {
        }

        protected SecretParameter(DeputyProps props): base(props)
        {
        }

        /// <summary>A token for the secret value.</summary>
        [JsiiProperty("value", "{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}")]
        public virtual Token Value
        {
            get => GetProperty<Token>();
            set => SetProperty(value);
        }

        [JsiiMethod("resolve", "{\"primitive\":\"any\"}", "[]")]
        public virtual object Resolve()
        {
            return InvokeMethod<object>(new object[]{});
        }
    }
}