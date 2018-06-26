using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.CodeBuild
{
    public class BuildEnvironmentVariable : DeputyBase, IBuildEnvironmentVariable
    {
        /// <summary>The type of environment variable.</summary>
        /// <remarks>default: PlainText</remarks>
        [JsiiProperty("type", "{\"primitive\":\"string\",\"optional\":true}", true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// The value of the environment variable (or the name of the parameter in
        /// the SSM parameter store.)
        /// </summary>
        [JsiiProperty("value", "{\"primitive\":\"any\"}", true)]
        public object Value
        {
            get;
            set;
        }
    }
}