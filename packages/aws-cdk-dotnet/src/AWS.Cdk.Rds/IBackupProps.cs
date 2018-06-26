using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Rds
{
    /// <summary>Backup configuration for RDS databases</summary>
    [JsiiInterface("@aws-cdk/rds", "jsii$_aws_cdk_rds$.BackupProps")]
    public interface IBackupProps
    {
        /// <summary>How many days to retain the backup</summary>
        [JsiiProperty("retentionDays", "{\"primitive\":\"number\"}")]
        double RetentionDays
        {
            get;
            set;
        }

        /// <summary>
        /// A daily time range in 24-hours UTC format in which backups preferably execute.
        /// 
        /// Must be at least 30 minutes long.
        /// 
        /// Example: '01:00-02:00'
        /// </summary>
        [JsiiProperty("preferredWindow", "{\"primitive\":\"string\",\"optional\":true}")]
        string PreferredWindow
        {
            get;
            set;
        }
    }
}