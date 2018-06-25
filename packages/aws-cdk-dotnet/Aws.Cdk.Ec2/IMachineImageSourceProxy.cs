using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>Interface for classes that can select an appropriate machine image to use</summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.IMachineImageSource")]
    public class IMachineImageSourceProxy : DeputyBase, IIMachineImageSource
    {
        private IMachineImageSourceProxy(ByRefValue reference): base(reference)
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