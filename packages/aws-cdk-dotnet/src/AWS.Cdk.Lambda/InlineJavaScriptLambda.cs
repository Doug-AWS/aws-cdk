using AWS.Cdk;
using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Lambda
{
    /// <summary>
    /// A lambda function with inline node.js code.
    /// 
    /// Usage:
    /// 
    ///     new InlineJavaScriptLambda(this, 'MyFunc', {
    ///       handler: {
    ///         fn: (event, context, callback) =&gt; {
    ///           console.log('hello, world');
    ///           callback();
    ///         }
    ///       }
    ///     });
    /// 
    /// This will define a node.js 6.10 function with the provided function has
    /// the handler code.
    /// </summary>
    [JsiiClass("@aws-cdk/lambda", "jsii$_aws_cdk_lambda$.InlineJavaScriptLambda", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"jsii$_aws_cdk_core$.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"props\",\"type\":{\"fqn\":\"jsii$_aws_cdk_lambda$.InlineJavaScriptLambdaProps\"}}]")]
    public class InlineJavaScriptLambda : Lambda
    {
        public InlineJavaScriptLambda(Construct parent, string name, IInlineJavaScriptLambdaProps props): base(new DeputyProps(new object[]{parent, name, props}))
        {
        }

        protected InlineJavaScriptLambda(ByRefValue reference): base(reference)
        {
        }

        protected InlineJavaScriptLambda(DeputyProps props): base(props)
        {
        }
    }
}