using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.SecurityGroupName", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class SecurityGroupName : Token
    {
        public SecurityGroupName(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected SecurityGroupName(ByRefValue reference): base(reference)
        {
        }

        protected SecurityGroupName(DeputyProps props): base(props)
        {
        }
    }
}