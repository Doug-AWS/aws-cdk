using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// An Amazon Resource Name (ARN).
    /// http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.Arn", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class Arn : Token
    {
        public Arn(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected Arn(ByRefValue reference): base(reference)
        {
        }

        protected Arn(DeputyProps props): base(props)
        {
        }

        /// <summary>
        /// Creates an ARN from components.
        /// If any component is the empty string,
        /// an empty string will be inserted into the generated ARN
        /// at the location that component corresponds to.
        /// </summary>
        [JsiiMethod("fromComponents", "{\"fqn\":\"jsii$_aws_cdk_core$.Arn\"}", "[{\"name\":\"components\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.ArnComponents\"}}]")]
        public virtual Arn FromComponents(IArnComponents components)
        {
            return InvokeMethod<Arn>(new object[]{components});
        }

        /// <summary>
        /// Given an ARN, parses it and returns components.
        /// 
        /// The ARN it will be parsed and validated. The separator (`sep`) will be
        /// set to '/' if the 6th component includes a '/', in which case, `resource`
        /// will be set to the value before the '/' and `resourceName` will be the
        /// rest. In case there is no '/', `resource` will be set to the 6th
        /// components and `resourceName` will be set to the rest of the string.
        /// </summary>
        /// <returns>
        /// an ArnComponents object which allows access to the various
        /// components of the ARN.
        /// </returns>
        [JsiiMethod("parse", "{\"fqn\":\"jsii$_aws_cdk_core$.ArnComponents\"}", "[{\"name\":\"arn\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual IArnComponents Parse(string arn)
        {
            return InvokeMethod<IArnComponents>(new object[]{arn});
        }
    }
}