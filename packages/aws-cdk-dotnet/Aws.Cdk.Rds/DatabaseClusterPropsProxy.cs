using Aws.Cdk.Resources.kms;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Aws.Cdk.Rds
{
    /// <summary>Properties for a new database cluster</summary>
    [JsiiInterfaceProxy("@aws-cdk/rds", "jsii$_aws_cdk_rds$.DatabaseClusterProps")]
    public class DatabaseClusterPropsProxy : DeputyBase, IDatabaseClusterProps
    {
        private DatabaseClusterPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>What kind of database to start</summary>
        [JsiiProperty("engine", "{\"fqn\":\"jsii$_aws_cdk_rds$.DatabaseClusterEngine\"}")]
        public virtual DatabaseClusterEngine Engine
        {
            get => GetProperty<DatabaseClusterEngine>();
            set => SetProperty(value);
        }

        /// <summary>
        /// How many replicas/instances to create
        /// 
        /// Has to be at least 1.
        /// </summary>
        /// <remarks>default: 2</remarks>
        [JsiiProperty("instances", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? Instances
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>Settings for the individual instances that are launched</summary>
        [JsiiProperty("instanceProps", "{\"fqn\":\"jsii$_aws_cdk_rds$.InstanceProps\"}")]
        public virtual IInstanceProps InstanceProps
        {
            get => GetProperty<IInstanceProps>();
            set => SetProperty(value);
        }

        /// <summary>Username and password for the administrative user</summary>
        [JsiiProperty("masterUser", "{\"fqn\":\"jsii$_aws_cdk_rds$.Login\"}")]
        public virtual ILogin MasterUser
        {
            get => GetProperty<ILogin>();
            set => SetProperty(value);
        }

        /// <summary>Backup settings</summary>
        [JsiiProperty("backup", "{\"fqn\":\"jsii$_aws_cdk_rds$.BackupProps\",\"optional\":true}")]
        public virtual IBackupProps Backup
        {
            get => GetProperty<IBackupProps>();
            set => SetProperty(value);
        }

        /// <summary>
        /// What port to listen on
        /// 
        /// If not supplied, the default for the engine is used.
        /// </summary>
        [JsiiProperty("port", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? Port
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// An optional identifier for the cluster
        /// 
        /// If not supplied, a name is automatically generated.
        /// </summary>
        [JsiiProperty("clusterIdentifier", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string ClusterIdentifier
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Base identifier for instances
        /// 
        /// Every replica is named by appending the replica number to this string, 1-based.
        /// 
        /// If not given, the clusterIdentifier is used with the word "Instance" appended.
        /// 
        /// If clusterIdentifier is also not given, the identifier is automatically generated.
        /// </summary>
        [JsiiProperty("instanceIdentifierBase", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string InstanceIdentifierBase
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Name of a database which is automatically created inside the cluster</summary>
        [JsiiProperty("defaultDatabaseName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string DefaultDatabaseName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>ARN of KMS key if you want to enable storage encryption</summary>
        [JsiiProperty("kmsKeyArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.kms.KeyArn\",\"optional\":true}")]
        public virtual KeyArn KmsKeyArn
        {
            get => GetProperty<KeyArn>();
            set => SetProperty(value);
        }

        /// <summary>
        /// A daily time range in 24-hours UTC format in which backups preferably execute.
        /// 
        /// Must be at least 30 minutes long.
        /// 
        /// Example: '01:00-02:00'
        /// </summary>
        [JsiiProperty("preferredMaintenanceWindow", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string PreferredMaintenanceWindow
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>Additional parameters to pass to the database engine</summary>
        [JsiiProperty("parameters", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}},\"optional\":true}")]
        public virtual IDictionary<string, object> Parameters
        {
            get => GetProperty<IDictionary<string, object>>();
            set => SetProperty(value);
        }
    }
}