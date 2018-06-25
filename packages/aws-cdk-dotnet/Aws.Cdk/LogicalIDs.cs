using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    /// <summary>
    /// Class that keeps track of the logical IDs that are assigned to resources
    /// 
    /// Supports renaming the generated IDs.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.LogicalIDs", "[{\"name\":\"namingScheme\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.IAddressingScheme\"}}]")]
    public class LogicalIDs : DeputyBase
    {
        public LogicalIDs(IIAddressingScheme namingScheme): base(new DeputyProps(new object[]{namingScheme}))
        {
        }

        protected LogicalIDs(ByRefValue reference): base(reference)
        {
        }

        protected LogicalIDs(DeputyProps props): base(props)
        {
        }

        /// <summary>Rename a logical ID from an old ID to a new ID</summary>
        [JsiiMethod("renameLogical", null, "[{\"name\":\"oldId\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"newId\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual void RenameLogical(string oldId, string newId)
        {
            InvokeVoidMethod(new object[]{oldId, newId});
        }

        /// <summary>Return the logical ID for the given stack element</summary>
        [JsiiMethod("getLogicalId", "{\"primitive\":\"string\"}", "[{\"name\":\"stackElement\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.StackElement\"}}]")]
        public virtual string GetLogicalId(StackElement stackElement)
        {
            return InvokeMethod<string>(new object[]{stackElement});
        }

        /// <summary>
        /// Throw an error if not all renames have been used
        /// 
        /// This is to assure that users didn't make typoes when registering renames.
        /// </summary>
        [JsiiMethod("assertAllRenamesApplied", null, "[]")]
        public virtual void AssertAllRenamesApplied()
        {
            InvokeVoidMethod(new object[]{});
        }
    }
}