using Aws.Cdk.Resources.ec2;
using Aws.Cdk.Resources.rds;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rds
{
    /// <summary>Properties that describe an existing cluster instance</summary>
    [JsiiInterfaceProxy("@aws-cdk/rds", "jsii$_aws_cdk_rds$.DatabaseClusterRefProps")]
    public class DatabaseClusterRefPropsProxy : DeputyBase, IDatabaseClusterRefProps
    {
        private DatabaseClusterRefPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The database port</summary>
        [JsiiProperty("port", "{\"fqn\":\"jsii$_aws_cdk_rds$.Port\"}")]
        public virtual Port Port
        {
            get => GetProperty<Port>();
            set => SetProperty(value);
        }

        /// <summary>The security group for this database cluster</summary>
        [JsiiProperty("securityGroupId", "{\"fqn\":\"jsii$_aws_cdk_resources$.ec2.SecurityGroupId\"}")]
        public virtual SecurityGroupId SecurityGroupId
        {
            get => GetProperty<SecurityGroupId>();
            set => SetProperty(value);
        }

        /// <summary>Identifier for the cluster</summary>
        [JsiiProperty("clusterIdentifier", "{\"fqn\":\"jsii$_aws_cdk_rds$.ClusterIdentifier\"}")]
        public virtual ClusterIdentifier ClusterIdentifier
        {
            get => GetProperty<ClusterIdentifier>();
            set => SetProperty(value);
        }

        /// <summary>Identifier for the instances</summary>
        [JsiiProperty("instanceIdentifiers", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_rds$.InstanceIdentifier\"}}}")]
        public virtual InstanceIdentifier[] InstanceIdentifiers
        {
            get => GetProperty<InstanceIdentifier[]>();
            set => SetProperty(value);
        }

        /// <summary>Cluster endpoint address</summary>
        [JsiiProperty("clusterEndpointAddress", "{\"fqn\":\"jsii$_aws_cdk_resources$.rds.DBClusterEndpointAddress\"}")]
        public virtual DBClusterEndpointAddress ClusterEndpointAddress
        {
            get => GetProperty<DBClusterEndpointAddress>();
            set => SetProperty(value);
        }

        /// <summary>Reader endpoint address</summary>
        [JsiiProperty("readerEndpointAddress", "{\"fqn\":\"jsii$_aws_cdk_resources$.rds.DBClusterEndpointAddress\"}")]
        public virtual DBClusterEndpointAddress ReaderEndpointAddress
        {
            get => GetProperty<DBClusterEndpointAddress>();
            set => SetProperty(value);
        }

        /// <summary>Endpoint addresses of individual instances</summary>
        [JsiiProperty("instanceEndpointAddresses", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_resources$.rds.DBClusterEndpointAddress\"}}}")]
        public virtual DBClusterEndpointAddress[] InstanceEndpointAddresses
        {
            get => GetProperty<DBClusterEndpointAddress[]>();
            set => SetProperty(value);
        }
    }
}