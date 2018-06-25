using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.ParameterProps")]
    public class ParameterPropsProxy : DeputyBase, IParameterProps
    {
        private ParameterPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The data type for the parameter (DataType).</summary>
        [JsiiProperty("type", "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// A value of the appropriate type for the template to use if no value is specified
        /// when a stack is created. If you define constraints for the parameter, you must specify
        /// a value that adheres to those constraints.
        /// </summary>
        [JsiiProperty("default", "{\"primitive\":\"any\",\"optional\":true}")]
        public virtual object Default
        {
            get => GetProperty<object>();
            set => SetProperty(value);
        }

        /// <summary>A regular expression that represents the patterns to allow for String types.</summary>
        [JsiiProperty("allowedPattern", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string AllowedPattern
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>An array containing the list of values allowed for the parameter.</summary>
        [JsiiProperty("allowedValues", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}},\"optional\":true}")]
        public virtual string[] AllowedValues
        {
            get => GetProperty<string[]>();
            set => SetProperty(value);
        }

        /// <summary>
        /// A string that explains a constraint when the constraint is violated.
        /// For example, without a constraint description, a parameter that has an allowed
        /// pattern of [A-Za-z0-9]+ displays the following error message when the user specifies
        /// an invalid value:
        /// </summary>
        [JsiiProperty("constraintDescription", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string ConstraintDescription
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>A string of up to 4000 characters that describes the parameter.</summary>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Description
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>An integer value that determines the largest number of characters you want to allow for String types.</summary>
        [JsiiProperty("maxLength", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MaxLength
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>A numeric value that determines the largest numeric value you want to allow for Number types.</summary>
        [JsiiProperty("maxValue", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MaxValue
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>An integer value that determines the smallest number of characters you want to allow for String types.</summary>
        [JsiiProperty("minLength", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MinLength
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>A numeric value that determines the smallest numeric value you want to allow for Number types.</summary>
        [JsiiProperty("minValue", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MinValue
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>
        /// Whether to mask the parameter value when anyone makes a call that describes the stack.
        /// If you set the value to ``true``, the parameter value is masked with asterisks (``*****``).
        /// </summary>
        [JsiiProperty("noEcho", "{\"primitive\":\"boolean\",\"optional\":true}")]
        public virtual bool? NoEcho
        {
            get => GetProperty<bool? >();
            set => SetProperty(value);
        }
    }
}