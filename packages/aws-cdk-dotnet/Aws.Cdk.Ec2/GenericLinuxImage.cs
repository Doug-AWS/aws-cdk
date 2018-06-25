using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Aws.Cdk.Ec2
{
    /// <summary>
    /// Construct a Linux machine image from an AMI map
    /// 
    /// Linux images IDs are not published to SSM parameter store yet, so you'll have to
    /// manually specify an AMI map.
    /// </summary>
    [JsiiClass("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.GenericLinuxImage", "[{\"name\":\"amiMap\",\"type\":{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"string\"}}}}]")]
    public class GenericLinuxImage : DeputyBase, IIMachineImageSource
    {
        public GenericLinuxImage(IDictionary<string, string> amiMap): base(new DeputyProps(new object[]{amiMap}))
        {
        }

        protected GenericLinuxImage(ByRefValue reference): base(reference)
        {
        }

        protected GenericLinuxImage(DeputyProps props): base(props)
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