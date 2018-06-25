using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Aws.Cdk
{
    /// <summary>CloudFormation template options for a stack.</summary>
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.TemplateOptions")]
    public class TemplateOptionsProxy : DeputyBase, ITemplateOptions
    {
        private TemplateOptionsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// Gets or sets the description of this stack.
        /// If provided, it will be included in the CloudFormation template's "Description" attribute.
        /// </summary>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Description
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Gets or sets the AWSTemplateFormatVersion field of the CloudFormation template.</summary>
        [JsiiProperty("templateFormatVersion", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string TemplateFormatVersion
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Gets or sets the top-level template transform for this stack (e.g. "AWS::Serverless-2016-10-31").</summary>
        [JsiiProperty("transform", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Transform
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Metadata associated with the CloudFormation template.</summary>
        [JsiiProperty("metadata", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}},\"optional\":true}")]
        public virtual IDictionary<string, object> Metadata
        {
            get => GetProperty<IDictionary<string, object>>();
            set => SetProperty(value);
        }
    }
}