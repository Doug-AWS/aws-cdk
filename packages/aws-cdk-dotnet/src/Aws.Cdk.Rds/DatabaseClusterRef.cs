using Aws.Cdk;
using Aws.Cdk.Ec2;
using Aws.Cdk.Resources.ec2;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rds
{
    /// <summary>Create a clustered database with a given number of instances.</summary>
    [JsiiClass("@aws-cdk/rds", "jsii$_aws_cdk_rds$.DatabaseClusterRef", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public abstract class DatabaseClusterRef : Construct, IIDefaultConnectable
    {
        protected DatabaseClusterRef(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected DatabaseClusterRef(ByRefValue reference): base(reference)
        {
        }

        protected DatabaseClusterRef(DeputyProps props): base(props)
        {
        }

        /// <summary>Default port to connect to this database</summary>
        [JsiiProperty("defaultPortRange", "{\"fqn\":\"jsii$_aws_cdk_ec2$.IPortRange\"}")]
        public virtual IIPortRange DefaultPortRange
        {
            get => GetProperty<IIPortRange>();
        }

        /// <summary>Access to the network connections</summary>
        [JsiiProperty("connections", "{\"fqn\":\"jsii$_aws_cdk_ec2$.DefaultConnections\"}")]
        public virtual DefaultConnections Connections
        {
            get => GetProperty<DefaultConnections>();
        }

        /// <summary>Identifier of the cluster</summary>
        [JsiiProperty("clusterIdentifier", "{\"fqn\":\"jsii$_aws_cdk_rds$.ClusterIdentifier\"}")]
        public virtual ClusterIdentifier ClusterIdentifier
        {
            get => GetProperty<ClusterIdentifier>();
        }

        /// <summary>Identifiers of the replicas</summary>
        [JsiiProperty("instanceIdentifiers", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_rds$.InstanceIdentifier\"}}}")]
        public virtual InstanceIdentifier[] InstanceIdentifiers
        {
            get => GetProperty<InstanceIdentifier[]>();
        }

        /// <summary>The endpoint to use for read/write operations</summary>
        [JsiiProperty("clusterEndpoint", "{\"fqn\":\"jsii$_aws_cdk_rds$.Endpoint\"}")]
        public virtual Endpoint ClusterEndpoint
        {
            get => GetProperty<Endpoint>();
        }

        /// <summary>Endpoint to use for load-balanced read-only operations.</summary>
        [JsiiProperty("readerEndpoint", "{\"fqn\":\"jsii$_aws_cdk_rds$.Endpoint\"}")]
        public virtual Endpoint ReaderEndpoint
        {
            get => GetProperty<Endpoint>();
        }

        /// <summary>Endpoints which address each individual replica.</summary>
        [JsiiProperty("instanceEndpoints", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"fqn\":\"jsii$_aws_cdk_rds$.Endpoint\"}}}")]
        public virtual Endpoint[] InstanceEndpoints
        {
            get => GetProperty<Endpoint[]>();
        }

        /// <summary>The security group for this database cluster</summary>
        [JsiiProperty("securityGroupId", "{\"fqn\":\"jsii$_aws_cdk_resources$.ec2.SecurityGroupId\"}")]
        protected virtual SecurityGroupId SecurityGroupId
        {
            get => GetProperty<SecurityGroupId>();
        }

        /// <summary>Import an existing DatabaseCluster from properties</summary>
        [JsiiMethod("import", "{\"fqn\":\"jsii$_aws_cdk_rds$.DatabaseClusterRef\"}", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_rds$.DatabaseClusterRefProps\"}}]")]
        public virtual DatabaseClusterRef Import(Construct parent, string name, IDatabaseClusterRefProps props)
        {
            return InvokeMethod<DatabaseClusterRef>(new object[]{parent, name, props});
        }

        /// <summary>Export a Database Cluster for importing in another stack</summary>
        [JsiiMethod("export", "{\"fqn\":\"jsii$_aws_cdk_rds$.DatabaseClusterRefProps\"}", "[]")]
        public virtual IDatabaseClusterRefProps Export()
        {
            return InvokeMethod<IDatabaseClusterRefProps>(new object[]{});
        }
    }
}