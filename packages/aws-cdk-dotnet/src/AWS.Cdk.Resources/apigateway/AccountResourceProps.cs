using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Resources.apigateway
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-account.html </remarks>
    public class AccountResourceProps : DeputyBase, IAccountResourceProps
    {
        /// <summary>AWS::ApiGateway::Account.CloudWatchRoleArn</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-account.html#cfn-apigateway-account-cloudwatchrolearn </remarks>
        [JsiiProperty("cloudWatchRoleArn", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"jsii$_aws_cdk_core$.Token\"}]},\"optional\":true}", true)]
        public object CloudWatchRoleArn
        {
            get;
            set;
        }
    }
}