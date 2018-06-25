using Aws.Cdk;
using Aws.Cdk.Resources.cloudtrail;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.CloudTrail
{
    /// <summary>
    /// Cloud trail allows you to log events that happen in your AWS account
    /// For example:
    /// 
    /// import { CloudTrail } from '@aws-cdk/ec2'
    /// 
    /// const cloudTrail = new CloudTrail(this, 'MyTrail');
    /// </summary>
    [JsiiClass("@aws-cdk/cloudtrail", "jsii$_aws_cdk_cloudtrail$.CloudTrail", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_cloudtrail$.CloudTrailProps\",\"optional\":true}}]")]
    public class CloudTrail : Construct
    {
        public CloudTrail(Construct parent, string name, ICloudTrailProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected CloudTrail(ByRefValue reference): base(reference)
        {
        }

        protected CloudTrail(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("cloudTrailArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.cloudtrail.TrailArn\"}")]
        public virtual TrailArn CloudTrailArn
        {
            get => GetProperty<TrailArn>();
        }

        /// <summary>
        /// When an event occurs in your account, CloudTrail evaluates whether the event matches the settings for your trails.
        /// Only events that match your trail settings are delivered to your Amazon S3 bucket and Amazon CloudWatch Logs log group.
        /// 
        /// This method adds an S3 Data Event Selector for filtering events that match S3 operations.
        /// 
        /// Data events: These events provide insight into the resource operations performed on or within a resource.
        /// These are also known as data plane operations.
        /// </summary>
        /// <param name = "readWriteType">
        /// the configuration type to log for this data event
        /// Eg, ReadWriteType.ReadOnly will only log "read" events for S3 objects that match a filter)
        /// </param>
        [JsiiMethod("addS3EventSelector", null, "[{\"name\":\"prefixes\",\"type\":{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}},{\"name\":\"readWriteType\",\"type\":{\"fqn\":\"jsii$_aws_cdk_cloudtrail$.ReadWriteType\"}}]")]
        public virtual void AddS3EventSelector(string[] prefixes, ReadWriteType readWriteType)
        {
            InvokeVoidMethod(new object[]{prefixes, readWriteType});
        }
    }
}