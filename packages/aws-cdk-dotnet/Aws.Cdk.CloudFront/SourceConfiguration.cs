using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Aws.Cdk.CloudFront
{
    /// <summary>
    /// A source configuration is a wrapper for CloudFront origins and behaviors.
    /// An origin is what CloudFront will "be in front of" - that is, CloudFront will pull it's assets from an origin.
    /// 
    /// If you're using s3 as a source - pass the `s3Origin` property, otherwise, pass the `customOriginSource` property.
    /// 
    /// One or the other must be passed, and it is invalid to pass both in the same SourceConfiguration.
    /// </summary>
    public class SourceConfiguration : DeputyBase, ISourceConfiguration
    {
        /// <summary>An s3 origin source - if you're using s3 for your assets</summary>
        [JsiiProperty("s3OriginSource", "{\"fqn\":\"jsii$_aws_cdk_cloudfront$.S3OriginConfig\",\"optional\":true}", true)]
        public IS3OriginConfig S3OriginSource
        {
            get;
        }

        /// <summary>A custom origin source - for all non-s3 sources.</summary>
        [JsiiProperty("customOriginSource", "{\"fqn\":\"jsii$_aws_cdk_cloudfront$.CustomOriginConfig\",\"optional\":true}", true)]
        public ICustomOriginConfig CustomOriginSource
        {
            get;
        }

        /// <summary>
        /// The behaviors associated with this source.
        /// At least one (default) behavior must be included.
        /// </summary>
        [JsiiProperty("behaviors", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_cloudfront$.Behavior\"}}}", true)]
        public IBehavior[] Behaviors
        {
            get;
        }

        /// <summary>The relative path to the origin root to use for sources.</summary>
        /// <remarks>default: /</remarks>
        [JsiiProperty("originPath", "{\"primitive\":\"string\",\"optional\":true}", true)]
        public string OriginPath
        {
            get;
        }

        /// <summary>Any additional headers to pass to the origin</summary>
        /// <remarks>default: no additional headers are passed</remarks>
        [JsiiProperty("originHeaders", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"string\"}},\"optional\":true}", true)]
        public IDictionary<string, string> OriginHeaders
        {
            get;
        }
    }
}