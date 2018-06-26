using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>
    /// Instance type for EC2 instances
    /// 
    /// This class takes a combination of a class and size.
    /// 
    /// Be aware that not all combinations of class and size are available, and not all
    /// classes are available in all regions.
    /// </summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.InstanceTypePair", "[{\"name\":\"instanceClass\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.InstanceClass\"}},{\"name\":\"instanceSize\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.InstanceSize\"}}]")]
    public class InstanceTypePair : InstanceType
    {
        public InstanceTypePair(InstanceClass instanceClass, InstanceSize instanceSize): base(new DeputyProps(new object[]{instanceClass, instanceSize}))
        {
        }

        protected InstanceTypePair(ByRefValue reference): base(reference)
        {
        }

        protected InstanceTypePair(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("instanceClass", "{\"fqn\":\"jsii$_aws_cdk_ec2$.InstanceClass\"}")]
        public virtual InstanceClass InstanceClass
        {
            get => GetProperty<InstanceClass>();
        }

        [JsiiProperty("instanceSize", "{\"fqn\":\"jsii$_aws_cdk_ec2$.InstanceSize\"}")]
        public virtual InstanceSize InstanceSize
        {
            get => GetProperty<InstanceSize>();
        }
    }
}