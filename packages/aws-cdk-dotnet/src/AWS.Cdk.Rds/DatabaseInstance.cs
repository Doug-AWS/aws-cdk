using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Rds
{
    /// <summary>
    /// Create a database instance
    /// 
    /// This can be a standalone database instance, or part of a cluster.
    /// </summary>
    [JsiiClass("@aws-cdk/rds", "jsii$_aws_cdk_rds$.DatabaseInstance", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseInstance : Construct
    {
        public DatabaseInstance(Construct parent, string name): base(new DeputyProps(new object[]{parent, name}))
        {
        }

        protected DatabaseInstance(ByRefValue reference): base(reference)
        {
        }

        protected DatabaseInstance(DeputyProps props): base(props)
        {
        }
    }
}