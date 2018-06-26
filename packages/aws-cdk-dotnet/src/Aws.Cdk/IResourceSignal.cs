using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// When AWS CloudFormation creates the associated resource, configures the number of required success signals and
    /// the length of time that AWS CloudFormation waits for those signals.
    /// </summary>
    [JsiiInterface("@aws-cdk/core", "jsii$_aws_cdk_core$.ResourceSignal")]
    public interface IResourceSignal
    {
        /// <summary>
        /// The number of success signals AWS CloudFormation must receive before it sets the resource status as CREATE_COMPLETE.
        /// If the resource receives a failure signal or doesn't receive the specified number of signals before the timeout period
        /// expires, the resource creation fails and AWS CloudFormation rolls the stack back.
        /// </summary>
        [JsiiProperty("count", "{\"primitive\":\"number\",\"optional\":true}")]
        double? Count
        {
            get;
            set;
        }

        /// <summary>
        /// The length of time that AWS CloudFormation waits for the number of signals that was specified in the Count property.
        /// The timeout period starts after AWS CloudFormation starts creating the resource, and the timeout expires no sooner
        /// than the time you specify but can occur shortly thereafter. The maximum time that you can specify is 12 hours.
        /// </summary>
        [JsiiProperty("timeout", "{\"primitive\":\"string\",\"optional\":true}")]
        string Timeout
        {
            get;
            set;
        }
    }
}