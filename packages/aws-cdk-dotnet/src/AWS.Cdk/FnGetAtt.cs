using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    /// <summary>The Fn::GetAtt intrinsic function returns the value of an attribute from a resource in the template.</summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnGetAtt", "[{\"name\":\"logicalNameOfResource\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"attributeName\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FnGetAtt : Fn
    {
        public FnGetAtt(string logicalNameOfResource, string attributeName): base(new DeputyProps(new object[]{logicalNameOfResource, attributeName}))
        {
        }

        protected FnGetAtt(ByRefValue reference): base(reference)
        {
        }

        protected FnGetAtt(DeputyProps props): base(props)
        {
        }
    }
}