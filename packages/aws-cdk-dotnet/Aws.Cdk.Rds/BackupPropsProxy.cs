using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rds
{
    /// <summary>Backup configuration for RDS databases</summary>
    [JsiiInterfaceProxy("@aws-cdk/rds", "jsii$_aws_cdk_rds$.BackupProps")]
    public class BackupPropsProxy : DeputyBase, IBackupProps
    {
        private BackupPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>How many days to retain the backup</summary>
        [JsiiProperty("retentionDays", "{\"primitive\":\"number\"}")]
        public virtual double RetentionDays
        {
            get => GetProperty<double>();
            set => SetProperty(value);
        }

        /// <summary>
        /// A daily time range in 24-hours UTC format in which backups preferably execute.
        /// 
        /// Must be at least 30 minutes long.
        /// 
        /// Example: '01:00-02:00'
        /// </summary>
        [JsiiProperty("preferredWindow", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string PreferredWindow
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}