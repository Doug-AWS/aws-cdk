using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>Interface for classes that implementation logical ID assignment strategies</summary>
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.IAddressingScheme")]
    public class IAddressingSchemeProxy : DeputyBase, IIAddressingScheme
    {
        private IAddressingSchemeProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Return the logical ID for the given list of Construct names on the path.</summary>
        [JsiiMethod("allocateAddress", "{\"primitive\":\"string\"}", "[{\"name\":\"addressComponents\",\"type\":{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}}]")]
        public virtual string AllocateAddress(string[] addressComponents)
        {
            return InvokeMethod<string>(new object[]{addressComponents});
        }
    }
}