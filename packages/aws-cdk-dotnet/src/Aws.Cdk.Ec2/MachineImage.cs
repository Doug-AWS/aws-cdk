using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>
    /// Representation of a machine to be launched
    /// 
    /// Combines an AMI ID with an OS.
    /// </summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.MachineImage", "[{\"name\":\"imageId\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"os\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.OperatingSystem\"}}]")]
    public class MachineImage : DeputyBase
    {
        public MachineImage(string imageId, OperatingSystem os): base(new DeputyProps(new object[]{imageId, os}))
        {
        }

        protected MachineImage(ByRefValue reference): base(reference)
        {
        }

        protected MachineImage(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("imageId", "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetProperty<string>();
        }

        [JsiiProperty("os", "{\"fqn\":\"jsii$_aws_cdk_ec2$.OperatingSystem\"}")]
        public virtual OperatingSystem Os
        {
            get => GetProperty<OperatingSystem>();
        }
    }
}