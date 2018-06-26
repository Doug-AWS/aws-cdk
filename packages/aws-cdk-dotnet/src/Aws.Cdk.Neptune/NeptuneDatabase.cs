using Aws.Cdk;
using Aws.Cdk.Ec2;
using Aws.Cdk.Rds;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Neptune
{
    /// <summary>
    /// Neptune Graph Database cluster
    /// 
    /// Creates a new Neptune database cluster with a given number of replicas.
    /// </summary>
    [JsiiClass("@aws-cdk/neptune", "jsii$_aws_cdk_neptune$.NeptuneDatabase", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_neptune$.NeptuneDatabaseProps\"}}]")]
    public class NeptuneDatabase : Construct, IIConnectable
    {
        public NeptuneDatabase(Construct parent, string name, INeptuneDatabaseProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected NeptuneDatabase(ByRefValue reference): base(reference)
        {
        }

        protected NeptuneDatabase(DeputyProps props): base(props)
        {
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

        [JsiiProperty("connections", "{\"fqn\":\"jsii$_aws_cdk_ec2$.DefaultConnections\"}")]
        public virtual DefaultConnections Connections
        {
            get => GetProperty<DefaultConnections>();
        }
    }
}