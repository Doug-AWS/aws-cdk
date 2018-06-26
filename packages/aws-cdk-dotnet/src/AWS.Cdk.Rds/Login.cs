using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Rds
{
    /// <summary>Username and password combination</summary>
    public class Login : DeputyBase, ILogin
    {
        /// <summary>Username</summary>
        [JsiiProperty("username", "{\"fqn\":\"jsii$_aws_cdk_rds$.Username\"}", true)]
        public Username Username
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
        [JsiiProperty("password", "{\"fqn\":\"jsii$_aws_cdk_rds$.Password\"}", true)]
        public Password Password
        {
            get;
            set;
        }
    }
}