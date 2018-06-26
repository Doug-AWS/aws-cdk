using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>
    /// Select the latest version of the indicated Windows version
    /// 
    /// The AMI ID is selected using the values published to the SSM parameter store.
    /// 
    /// https://aws.amazon.com/blogs/mt/query-for-the-latest-windows-ami-using-systems-manager-parameter-store/
    /// </summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.WindowsImage", "[{\"name\":\"version\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.WindowsVersion\"}}]")]
    public class WindowsImage : DeputyBase, IIMachineImageSource
    {
        public WindowsImage(WindowsVersion version): base(new DeputyProps(new object[]{version}))
        {
        }

        protected WindowsImage(ByRefValue reference): base(reference)
        {
        }

        protected WindowsImage(DeputyProps props): base(props)
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