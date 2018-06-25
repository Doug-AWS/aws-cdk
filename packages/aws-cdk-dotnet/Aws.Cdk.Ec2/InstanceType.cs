using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>
    /// Instance type for EC2 instances
    /// 
    /// This class takes a literal string, good if you already
    /// know the identifier of the type you want.
    /// </summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.InstanceType", "[{\"name\":\"instanceTypeIdentifier\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InstanceType : DeputyBase
    {
        public InstanceType(string instanceTypeIdentifier): base(new DeputyProps(new object[]{instanceTypeIdentifier}))
        {
        }

        protected InstanceType(ByRefValue reference): base(reference)
        {
        }

        protected InstanceType(DeputyProps props): base(props)
        {
        }

        /// <summary>Return the instance type as a dotted string</summary>
        [JsiiMethod("toString", "{\"primitive\":\"string\"}", "[]")]
        public override string ToString()
        {
            return InvokeMethod<string>(new object[]{});
        }
    }
}