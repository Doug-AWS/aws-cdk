using AWS.Cdk;
using AWS.Cdk.Ec2;
using AWS.Cdk.Resources.ec2;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Rds
{
    /// <summary>Create a clustered database with a given number of instances.</summary>
    [JsiiClass("@aws-cdk/rds", "jsii$_aws_cdk_rds$.DatabaseCluster", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_rds$.DatabaseClusterProps\"}}]")]
    public class DatabaseCluster : DatabaseClusterRef
    {
        public DatabaseCluster(Construct parent, string name, IDatabaseClusterProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected DatabaseCluster(ByRefValue reference): base(reference)
        {
        }

        protected DatabaseCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Identifier of the cluster</summary>
        [JsiiProperty("clusterIdentifier", "{\"fqn\":\"jsii$_aws_cdk_rds$.ClusterIdentifier\"}")]
        public override ClusterIdentifier ClusterIdentifier
        {
            get => GetProperty<ClusterIdentifier>();
        }

        /// <summary>Identifiers of the replicas</summary>
        [JsiiProperty("instanceIdentifiers", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_rds$.InstanceIdentifier\"}}}")]
        public override InstanceIdentifier[] InstanceIdentifiers
        {
            get => GetProperty<InstanceIdentifier[]>();
        }

        /// <summary>The endpoint to use for read/write operations</summary>
        [JsiiProperty("clusterEndpoint", "{\"fqn\":\"jsii$_aws_cdk_rds$.Endpoint\"}")]
        public override Endpoint ClusterEndpoint
        {
            get => GetProperty<Endpoint>();
        }

        /// <summary>Endpoint to use for load-balanced read-only operations.</summary>
        [JsiiProperty("readerEndpoint", "{\"fqn\":\"jsii$_aws_cdk_rds$.Endpoint\"}")]
        public override Endpoint ReaderEndpoint
        {
            get => GetProperty<Endpoint>();
        }

        /// <summary>Endpoints which address each individual replica.</summary>
        [JsiiProperty("instanceEndpoints", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_rds$.Endpoint\"}}}")]
        public override Endpoint[] InstanceEndpoints
        {
            get => GetProperty<Endpoint[]>();
        }

        /// <summary>Default port to connect to this database</summary>
        [JsiiProperty("defaultPortRange", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}")]
        public override IIPortRange DefaultPortRange
        {
            get => GetProperty<IIPortRange>();
        }

        /// <summary>Access to the network connections</summary>
        [JsiiProperty("connections", "{\"fqn\":\"jsii$_aws_cdk_ec2$.DefaultConnections\"}")]
        public override DefaultConnections Connections
        {
            get => GetProperty<DefaultConnections>();
        }

        /// <summary>Security group identifier of this database</summary>
        [JsiiProperty("securityGroupId", "{\"fqn\":\"jsii$_aws_cdk_resources$.ec2.SecurityGroupId\"}")]
        protected override SecurityGroupId SecurityGroupId
        {
            get => GetProperty<SecurityGroupId>();
            set => SetProperty(value);
        }
    }
}