using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Ec2
{
    /// <summary>OS features specialized for Linux</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.LinuxOS", "[]")]
    public class LinuxOS : OperatingSystem
    {
        public LinuxOS(): base(new DeputyProps(new object[]{}))
        {
        }

        protected LinuxOS(ByRefValue reference): base(reference)
        {
        }

        protected LinuxOS(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("type", "{\"fqn\":\"jsii$_aws_cdk_ec2$.OperatingSystemType\"}")]
        public override OperatingSystemType Type
        {
            get => GetProperty<OperatingSystemType>();
        }

        [JsiiMethod("createUserData", "{\"primitive\":\"string\"}", "[{\"name\":\"scripts\",\"type\":{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}}]")]
        public override string CreateUserData(string[] scripts)
        {
            return InvokeMethod<string>(new object[]{scripts});
        }
    }
}