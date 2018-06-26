using Aws.Cdk.Resources.ec2;
using Aws.Cdk.Resources.rds;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rds
{
    /// <summary>Properties that describe an existing cluster instance</summary>
    public class DatabaseClusterRefProps : DeputyBase, IDatabaseClusterRefProps
    {
        /// <summary>The database port</summary>
        [JsiiProperty("port", "{\"fqn\":\"jsii$_aws_cdk_rds$.Port\"}", true)]
        public Port Port
        {
            get;
            set;
        }

        /// <summary>The security group for this database cluster</summary>
        [JsiiProperty("securityGroupId", "{\"fqn\":\"jsii$_aws_cdk_resources$.ec2.SecurityGroupId\"}", true)]
        public SecurityGroupId SecurityGroupId
        {
            get;
            set;
        }

        /// <summary>Identifier for the cluster</summary>
        [JsiiProperty("clusterIdentifier", "{\"fqn\":\"jsii$_aws_cdk_rds$.ClusterIdentifier\"}", true)]
        public ClusterIdentifier ClusterIdentifier
        {
            get;
            set;
        }

        /// <summary>Identifier for the instances</summary>
        [JsiiProperty("instanceIdentifiers", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_rds$.InstanceIdentifier\"}}}", true)]
        public InstanceIdentifier[] InstanceIdentifiers
        {
            get;
            set;
        }

        /// <summary>Cluster endpoint address</summary>
        [JsiiProperty("clusterEndpointAddress", "{\"fqn\":\"jsii$_aws_cdk_resources$.rds.DBClusterEndpointAddress\"}", true)]
        public DBClusterEndpointAddress ClusterEndpointAddress
        {
            get;
            set;
        }

        /// <summary>Reader endpoint address</summary>
        [JsiiProperty("readerEndpointAddress", "{\"fqn\":\"jsii$_aws_cdk_resources$.rds.DBClusterEndpointAddress\"}", true)]
        public DBClusterEndpointAddress ReaderEndpointAddress
        {
            get;
            set;
        }

        /// <summary>Endpoint addresses of individual instances</summary>
        [JsiiProperty("instanceEndpointAddresses", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_resources$.rds.DBClusterEndpointAddress\"}}}", true)]
        public DBClusterEndpointAddress[] InstanceEndpointAddresses
        {
            get;
            set;
        }
    }
}