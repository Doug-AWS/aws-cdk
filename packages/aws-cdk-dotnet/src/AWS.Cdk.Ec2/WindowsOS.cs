using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>OS features specialized for Windows</summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.WindowsOS", "[]")]
    public class WindowsOS : OperatingSystem
    {
        public WindowsOS(): base(new DeputyProps(new object[]{}))
        {
        }

        protected WindowsOS(ByRefValue reference): base(reference)
        {
        }

        protected WindowsOS(DeputyProps props): base(props)
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