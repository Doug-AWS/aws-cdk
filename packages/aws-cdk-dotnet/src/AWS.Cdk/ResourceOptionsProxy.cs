using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace AWS.Cdk
{
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.ResourceOptions")]
    public class ResourceOptionsProxy : DeputyBase, IResourceOptions
    {
        private ResourceOptionsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// A condition to associate with this resource. This means that only if the condition evaluates to 'true' when the stack
        /// is deployed, the resource will be included. This is provided to allow CDK projects to produce legacy templates, but noramlly
        /// there is no need to use it in CDK projects.
        /// </summary>
        [JsiiProperty("condition", "{\"fqn\":\"jsii$_aws_cdk_core$.Condition\",\"optional\":true}")]
        public virtual Condition Condition
        {
            get => GetProperty<Condition>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Associate the CreationPolicy attribute with a resource to prevent its status from reaching create complete until
        /// AWS CloudFormation receives a specified number of success signals or the timeout period is exceeded. To signal a
        /// resource, you can use the cfn-signal helper script or SignalResource API. AWS CloudFormation publishes valid signals
        /// to the stack events so that you track the number of signals sent.
        /// </summary>
        [JsiiProperty("creationPolicy", "{\"fqn\":\"jsii$_aws_cdk_core$.CreationPolicy\",\"optional\":true}")]
        public virtual ICreationPolicy CreationPolicy
        {
            get => GetProperty<ICreationPolicy>();
            set => SetProperty(value);
        }

        /// <summary>
        /// With the DeletionPolicy attribute you can preserve or (in some cases) backup a resource when its stack is deleted.
        /// You specify a DeletionPolicy attribute for each resource that you want to control. If a resource has no DeletionPolicy
        /// attribute, AWS CloudFormation deletes the resource by default. Note that this capability also applies to update operations
        /// that lead to resources being removed.
        /// </summary>
        [JsiiProperty("deletionPolicy", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string DeletionPolicy
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Use the UpdatePolicy attribute to specify how AWS CloudFormation handles updates to the AWS::AutoScaling::AutoScalingGroup
        /// resource. AWS CloudFormation invokes one of three update policies depending on the type of change you make or whether a
        /// scheduled action is associated with the Auto Scaling group.
        /// </summary>
        [JsiiProperty("updatePolicy", "{\"fqn\":\"jsii$_aws_cdk_core$.UpdatePolicy\",\"optional\":true}")]
        public virtual IUpdatePolicy UpdatePolicy
        {
            get => GetProperty<IUpdatePolicy>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Metadata associated with the CloudFormation resource. This is not the same as the construct metadata which can be added
        /// using construct.addMetadata(), but would not appear in the CloudFormation template automatically.
        /// </summary>
        [JsiiProperty("metadata", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}},\"optional\":true}")]
        public virtual IDictionary<string, object> Metadata
        {
            get => GetProperty<IDictionary<string, object>>();
            set => SetProperty(value);
        }
    }
}