using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Iam
{
    /// <summary>
    /// The AWS::IAM::Policy resource associates an IAM policy with IAM users, roles,
    /// or groups. For more information about IAM policies, see [Overview of IAM
    /// Policies](http://docs.aws.amazon.com/IAM/latest/UserGuide/policies_overview.html)
    /// in the IAM User Guide guide.
    /// </summary>
    [JsiiClass("@aws-cdk/iam", "jsii$_aws_cdk_iam$.Policy", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.PolicyProps\",\"optional\":true}}]")]
    public class Policy : Construct, IIDependable
    {
        public Policy(Construct parent, string name, IPolicyProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Policy(ByRefValue reference): base(reference)
        {
        }

        protected Policy(DeputyProps props): base(props)
        {
        }

        /// <summary>The policy document.</summary>
        [JsiiProperty("document", "{\"fqn\":\"jsii$_aws_cdk_core$.PolicyDocument\"}")]
        public virtual PolicyDocument Document
        {
            get => GetProperty<PolicyDocument>();
        }

        /// <summary>The name of this policy.</summary>
        [JsiiProperty("policyName", "{\"primitive\":\"string\"}")]
        public virtual string PolicyName
        {
            get => GetProperty<string>();
        }

        /// <summary>Lists all the elements consumers should "depend-on".</summary>
        [JsiiProperty("dependencyElements", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_core$.IDependable\"}}}")]
        public virtual IIDependable[] DependencyElements
        {
            get => GetProperty<IIDependable[]>();
        }

        /// <summary>Adds a statement to the policy document.</summary>
        [JsiiMethod("addStatement", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddStatement(PolicyStatement statement)
        {
            InvokeVoidMethod(new object[]{statement});
        }

        /// <summary>Attaches this policy to a user.</summary>
        [JsiiMethod("attachToUser", null, "[{\"name\":\"user\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.User\"}}]")]
        public virtual void AttachToUser(User user)
        {
            InvokeVoidMethod(new object[]{user});
        }

        /// <summary>Attaches this policy to a role.</summary>
        [JsiiMethod("attachToRole", null, "[{\"name\":\"role\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.Role\"}}]")]
        public virtual void AttachToRole(Role role)
        {
            InvokeVoidMethod(new object[]{role});
        }

        /// <summary>Attaches this policy to a group.</summary>
        [JsiiMethod("attachToGroup", null, "[{\"name\":\"group\",\"type\":{\"fqn\":\"jsii$_aws_cdk_iam$.Group\"}}]")]
        public virtual void AttachToGroup(Group group)
        {
            InvokeVoidMethod(new object[]{group});
        }

        /// <summary>
        /// This method can be implemented by derived constructs in order to perform
        /// validation logic. It is called on all constructs before synthesis.
        /// </summary>
        [JsiiMethod("validate", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}", "[]")]
        public override string[] Validate()
        {
            return InvokeMethod<string[]>(new object[]{});
        }
    }
}