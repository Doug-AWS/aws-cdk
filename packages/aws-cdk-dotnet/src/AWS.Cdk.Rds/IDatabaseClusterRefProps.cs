using AWS.Cdk.Resources.ec2;
using AWS.Cdk.Resources.rds;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Rds
{
    /// <summary>Properties that describe an existing cluster instance</summary>
    [JsiiInterface("@aws-cdk/rds", "jsii$_aws_cdk_rds$.DatabaseClusterRefProps")]
    public interface IDatabaseClusterRefProps
    {
        /// <summary>The database port</summary>
        [JsiiProperty("port", "{\"fqn\":\"jsii$_aws_cdk_rds$.Port\"}")]
        Port Port
        {
            get;
            set;
        }

        /// <summary>The security group for this database cluster</summary>
        [JsiiProperty("securityGroupId", "{\"fqn\":\"jsii$_aws_cdk_resources$.ec2.SecurityGroupId\"}")]
        SecurityGroupId SecurityGroupId
        {
            get;
            set;
        }

        /// <summary>Identifier for the cluster</summary>
        [JsiiProperty("clusterIdentifier", "{\"fqn\":\"jsii$_aws_cdk_rds$.ClusterIdentifier\"}")]
        ClusterIdentifier ClusterIdentifier
        {
            get;
            set;
        }

        /// <summary>Identifier for the instances</summary>
        [JsiiProperty("instanceIdentifiers", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_rds$.InstanceIdentifier\"}}}")]
        InstanceIdentifier[] InstanceIdentifiers
        {
            get;
            set;
        }

        /// <summary>Cluster endpoint address</summary>
        [JsiiProperty("clusterEndpointAddress", "{\"fqn\":\"jsii$_aws_cdk_resources$.rds.DBClusterEndpointAddress\"}")]
        DBClusterEndpointAddress ClusterEndpointAddress
        {
            get;
            set;
        }

        /// <summary>Reader endpoint address</summary>
        [JsiiProperty("readerEndpointAddress", "{\"fqn\":\"jsii$_aws_cdk_resources$.rds.DBClusterEndpointAddress\"}")]
        DBClusterEndpointAddress ReaderEndpointAddress
        {
            get;
            set;
        }

        /// <summary>Endpoint addresses of individual instances</summary>
        [JsiiProperty("instanceEndpointAddresses", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_resources$.rds.DBClusterEndpointAddress\"}}}")]
        DBClusterEndpointAddress[] InstanceEndpointAddresses
        {
            get;
            set;
        }
    }
}