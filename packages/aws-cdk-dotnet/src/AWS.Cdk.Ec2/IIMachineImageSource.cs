using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Interface for classes that can select an appropriate machine image to use</summary>
    [JsiiInterface("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.IMachineImageSource")]
    public interface IIMachineImageSource
    {
        /// <summary>Return the image to use in the given context</summary>
        [JsiiMethod("getImage", "{\"fqn\":\"jsii$_aws_cdk_ec2$.MachineImage\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}}]")]
        MachineImage GetImage(Construct parent);
    }
}