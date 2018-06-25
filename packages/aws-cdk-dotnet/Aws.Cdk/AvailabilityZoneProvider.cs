using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>Context provider that will return the availability zones for the current account and region</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.AvailabilityZoneProvider", "[{\"name\":\"context\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}}]")]
    public class AvailabilityZoneProvider : DeputyBase
    {
        public AvailabilityZoneProvider(Construct context): base(new DeputyProps(new object[]{context}))
        {
        }

        protected AvailabilityZoneProvider(ByRefValue reference): base(reference)
        {
        }

        protected AvailabilityZoneProvider(DeputyProps props): base(props)
        {
        }

        /// <summary>Return the list of AZs for the current account and region</summary>
        [JsiiProperty("availabilityZones", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}")]
        public virtual string[] AvailabilityZones
        {
            get => GetProperty<string[]>();
        }
    }
}