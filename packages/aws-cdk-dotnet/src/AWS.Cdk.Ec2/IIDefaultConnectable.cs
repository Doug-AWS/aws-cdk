using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>An object that has a Connections object as well as a default port range.</summary>
    [JsiiInterface("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.IDefaultConnectable")]
    public interface IIDefaultConnectable : IIConnectable
    {
        [JsiiProperty("defaultPortRange", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}")]
        IIPortRange DefaultPortRange
        {
            get;
        }
    }
}