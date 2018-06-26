using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Rds
{
    /// <summary>Username and password combination</summary>
    [JsiiInterfaceProxy("@aws-cdk/rds", "jsii$_aws_cdk_rds$.Login")]
    public class LoginProxy : DeputyBase, ILogin
    {
        private LoginProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Username</summary>
        [JsiiProperty("username", "{\"fqn\":\"jsii$_aws_cdk_rds$.Username\"}")]
        public virtual Username Username
        {
            get => GetProperty<Username>();
            set => SetProperty(value);
        }

        /// <summary>
        /// Password
        /// 
        /// Do not put passwords in your CDK code directly. Import it from a Stack
        /// Parameter or the SSM Parameter Store instead.
        /// </summary>
        [JsiiProperty("password", "{\"fqn\":\"jsii$_aws_cdk_rds$.Password\"}")]
        public virtual Password Password
        {
            get => GetProperty<Password>();
            set => SetProperty(value);
        }
    }
}