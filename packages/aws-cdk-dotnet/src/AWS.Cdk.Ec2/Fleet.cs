using AWS.Cdk;
using AWS.Cdk.Iam;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>
    /// A Fleet represents a managed set of EC2 instances
    /// 
    /// The Fleet models a number of AutoScalingGroups, a launch configuration, a
    /// security group and an instance role.
    /// 
    /// It allows adding arbitrary commands to the startup scripts of the instances
    /// in the fleet.
    /// 
    /// The ASG spans all availability zones.
    /// </summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.Fleet", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.FleetProps\"}}]")]
    public class Fleet : Construct, IIClassicLoadBalancerTarget
    {
        public Fleet(Construct parent, string name, IFleetProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Fleet(ByRefValue reference): base(reference)
        {
        }

        protected Fleet(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("connectionPeer", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IConnectionPeer\"}")]
        public virtual IIConnectionPeer ConnectionPeer
        {
            get => GetProperty<IIConnectionPeer>();
        }

        /// <summary>The type of OS instances of this fleet are running.</summary>
        [JsiiProperty("osType", "{\"fqn\":\"jsii$_aws_cdk_ec2$.OperatingSystemType\"}")]
        public virtual OperatingSystemType OsType
        {
            get => GetProperty<OperatingSystemType>();
        }

        /// <summary>Allows specify security group connections for instances of this fleet.</summary>
        [JsiiProperty("connections", "{\"fqn\":\"jsii$_aws_cdk_ec2$.Connections\"}")]
        public virtual Connections Connections
        {
            get => GetProperty<Connections>();
        }

        /// <summary>The IAM role assumed by instances of this fleet.</summary>
        [JsiiProperty("role", "{\"fqn\":\"jsii$_aws_cdk_iam$.Role\"}")]
        public virtual Role Role
        {
            get => GetProperty<Role>();
        }

        /// <summary>Attach load-balanced target to a classic ELB</summary>
        [JsiiMethod("attachToClassicLB", null, "[{\"name\":\"loadBalancer\",\"type\":{\"fqn\":\"jsii$_aws_cdk_ec2$.ClassicLoadBalancer\"}}]")]
        public virtual void AttachToClassicLB(ClassicLoadBalancer loadBalancer)
        {
            InvokeVoidMethod(new object[]{loadBalancer});
        }

        /// <summary>
        /// Add command to the startup script of fleet instances.
        /// The command must be in the scripting language supported by the fleet's OS (i.e. Linux/Windows).
        /// </summary>
        [JsiiMethod("addUserData", null, "[{\"name\":\"script\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual void AddUserData(string script)
        {
            InvokeVoidMethod(new object[]{script});
        }

        [JsiiMethod("autoScalingGroupName", "{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}", "[]")]
        public virtual Token AutoScalingGroupName()
        {
            return InvokeMethod<Token>(new object[]{});
        }

        /// <summary>Adds a statement to the IAM role assumed by instances of this fleet.</summary>
        [JsiiMethod("addToRolePolicy", null, "[{\"name\":\"statement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.PolicyStatement\"}}]")]
        public virtual void AddToRolePolicy(PolicyStatement statement)
        {
            InvokeVoidMethod(new object[]{statement});
        }
    }
}