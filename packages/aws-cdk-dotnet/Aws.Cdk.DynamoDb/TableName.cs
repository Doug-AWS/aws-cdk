using Aws.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.DynamoDb
{
    [JsiiClass("@aws-cdk/dynamodb", "jsii$_aws_cdk_dynamodb$.TableName", "[{\"name\":\"valueOrFunction\",\"type\":{\"primitive\":\"any\",\"optional\":true}}]")]
    public class TableName : Token
    {
        public TableName(object valueOrFunction): base(new DeputyProps(new object[]{valueOrFunction}))
        {
        }

        protected TableName(ByRefValue reference): base(reference)
        {
        }

        protected TableName(DeputyProps props): base(props)
        {
        }
    }
}