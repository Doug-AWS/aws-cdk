using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Resources.apigateway
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-account.html </remarks>
    [JsiiInterfaceProxy("@aws-cdk/resources", "jsii$_aws_cdk_resources$.apigateway.AccountResourceProps")]
    public class AccountResourcePropsProxy : DeputyBase, IAccountResourceProps
    {
        private AccountResourcePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>AWS::ApiGateway::Account.CloudWatchRoleArn</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-account.html#cfn-apigateway-account-cloudwatchrolearn </remarks>
        [JsiiProperty("cloudWatchRoleArn", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}]},\"optional\":true}")]
        public virtual object CloudWatchRoleArn
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }
    }
}