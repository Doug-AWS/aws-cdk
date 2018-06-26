using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>
    /// Selects the latest version of Amazon Linux
    /// 
    /// The AMI ID is selected using the values published to the SSM parameter store.
    /// </summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.AmazonLinuxImage", "[{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.AmazonLinuxImageProps\",\"optional\":true}}]")]
    public class AmazonLinuxImage : DeputyBase, IIMachineImageSource
    {
        public AmazonLinuxImage(IAmazonLinuxImageProps props): base(new DeputyProps(new object[]{props}))
        {
        }

        protected AmazonLinuxImage(ByRefValue reference): base(reference)
        {
        }

        protected AmazonLinuxImage(DeputyProps props): base(props)
        {
        }

        /// <summary>Return the image to use in the given context</summary>
        [JsiiMethod("getImage", "{\"fqn\":\"jsii$_aws_cdk_ec2$.MachineImage\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}}]")]
        public virtual MachineImage GetImage(Construct parent)
        {
            return InvokeMethod<MachineImage>(new object[]{parent});
        }
    }
}