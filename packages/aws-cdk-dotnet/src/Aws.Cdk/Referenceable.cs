using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// A construct, which is part of a stack and can be referenced using it's logical ID
    /// using the CloudFormation intrinsic function { Ref: ID }.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.Referenceable", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class Referenceable : StackElement
    {
        protected Referenceable(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected Referenceable(ByRefValue reference): base(reference)
        {
        }

        protected Referenceable(DeputyProps props): base(props)
        {
        }

        /// <summary>Returns a token to a CloudFormation { Ref } that references this entity based on it's logical ID.</summary>
        [JsiiProperty("ref", "{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}")]
        public virtual Token Ref
        {
            get => GetProperty<Token>();
        }
    }
}