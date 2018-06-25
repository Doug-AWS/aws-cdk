using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.Rds
{
    /// <summary>Username and password combination</summary>
    [JsiiInterface("@aws-cdk/rds", "jsii$_aws_cdk_rds$.Login")]
    public interface ILogin
    {
        /// <summary>Username</summary>
        [JsiiProperty("username", "{\"fqn\":\"jsii$_aws_cdk_rds$.Username\"}")]
        Username Username
        {
            get;
            set;
        }

        /// <summary>
        /// Password
        /// 
        /// Do not put passwords in your CDK code directly. Import it from a Stack
        /// Parameter or the SSM Parameter Store instead.
        /// </summary>
        [JsiiProperty("password", "{\"fqn\":\"jsii$_aws_cdk_rds$.Password\"}")]
        Password Password
        {
            get;
            set;
        }
    }
}