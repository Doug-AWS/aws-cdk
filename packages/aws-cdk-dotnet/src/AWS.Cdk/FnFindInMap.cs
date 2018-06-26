using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk
{
    /// <summary>
    /// The intrinsic function Fn::FindInMap returns the value corresponding to keys in a two-level
    /// map that is declared in the Mappings section.
    /// </summary>
    [JsiiClass("@aws-cdk/core", "jsii$_aws_cdk_core$.FnFindInMap", "[{\"name\":\"mapName\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"topLevelKey\",\"type\":{\"primitive\":\"any\"}},{\"name\":\"secondLevelKey\",\"type\":{\"primitive\":\"any\"}}]")]
    public class FnFindInMap : Fn
    {
        public FnFindInMap(string mapName, object topLevelKey, object secondLevelKey): base(new DeputyProps(new object[]{mapName, topLevelKey, secondLevelKey}))
        {
        }

        protected FnFindInMap(ByRefValue reference): base(reference)
        {
        }

        protected FnFindInMap(DeputyProps props): base(props)
        {
        }
    }
}