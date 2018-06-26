using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk.DynamoDb
{
    [JsiiInterfaceProxy("@aws-cdk/dynamodb", "jsii$_aws_cdk_dynamodb$.TableProps")]
    public class TablePropsProxy : DeputyBase, ITableProps
    {
        private TablePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>
        /// The read capacity for the table. Careful if you add Global Secondary Indexes, as
        /// those will share the table's provisioned throughput.
        /// </summary>
        /// <remarks>default: 5</remarks>
        [JsiiProperty("readCapacity", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? ReadCapacity
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// The write capacity for the table. Careful if you add Global Secondary Indexes, as
        /// those will share the table's provisioned throughput.
        /// </summary>
        /// <remarks>default: 5</remarks>
        [JsiiProperty("writeCapacity", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? WriteCapacity
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>Enforces a particular physical table name.</summary>
        /// <remarks>default: &lt;generated&gt;</remarks>
        [JsiiProperty("tableName", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string TableName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}