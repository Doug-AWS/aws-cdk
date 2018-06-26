using Aws.Cdk;
using Aws.Cdk.Resources.dynamodb;
using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.DynamoDb
{
    /// <summary>Provides a DynamoDB table.</summary>
    [JsiiClass("@aws-cdk/dynamodb", "jsii$_aws_cdk_dynamodb$.Table", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_dynamodb$.TableProps\",\"optional\":true}}]")]
    public class Table : Construct
    {
        public Table(Construct parent, string name, ITableProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected Table(ByRefValue reference): base(reference)
        {
        }

        protected Table(DeputyProps props): base(props)
        {
        }

        [JsiiProperty("tableArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.dynamodb.TableArn\"}")]
        public virtual TableArn TableArn
        {
            get => GetProperty<TableArn>();
        }

        [JsiiProperty("tableName", "{\"fqn\":\"jsii$_aws_cdk_dynamodb$.TableName\"}")]
        public virtual TableName TableName
        {
            get => GetProperty<TableName>();
        }

        [JsiiProperty("tableStreamArn", "{\"fqn\":\"jsii$_aws_cdk_resources$.dynamodb.TableStreamArn\"}")]
        public virtual TableStreamArn TableStreamArn
        {
            get => GetProperty<TableStreamArn>();
        }

        [JsiiMethod("addPartitionKey", "{\"fqn\":\"jsii$_aws_cdk_dynamodb$.Table\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"type\",\"type\":{\"fqn\":\"jsii$_aws_cdk_dynamodb$.KeyAttributeType\"}}]")]
        public virtual Table AddPartitionKey(string name, KeyAttributeType type)
        {
            return InvokeMethod<Table>(new object[]{name, type});
        }

        [JsiiMethod("addSortKey", "{\"fqn\":\"jsii$_aws_cdk_dynamodb$.Table\"}", "[{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"type\",\"type\":{\"fqn\":\"jsii$_aws_cdk_dynamodb$.KeyAttributeType\"}}]")]
        public virtual Table AddSortKey(string name, KeyAttributeType type)
        {
            return InvokeMethod<Table>(new object[]{name, type});
        }

        /// <summary>
        /// This method can be implemented by derived constructs in order to perform
        /// validation logic. It is called on all constructs before synthesis.
        /// </summary>
        [JsiiMethod("validate", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}}}", "[]")]
        public override string[] Validate()
        {
            return InvokeMethod<string[]>(new object[]{});
        }
    }
}