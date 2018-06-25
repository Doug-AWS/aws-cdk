using AWS.Jsii.Runtime.Deputy;

namespace Aws.Cdk
{
    [JsiiInterfaceProxy("@aws-cdk/core", "jsii$_aws_cdk_core$.SecretProps")]
    public class SecretPropsProxy : DeputyBase, ISecretProps
    {
        private SecretPropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>The name of the SSM parameter where the secret value is stored.</summary>
        [JsiiProperty("ssmParameter", "{\"primitive\":\"string\"}")]
        public virtual string SsmParameter
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>A string of up to 4000 characters that describes the parameter.</summary>
        /// <remarks>default: No description</remarks>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Description
        {
            get => GetProperty<string>();
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

        /// <summary>An integer value that determines the largest number of characters you want to allow for String types.</summary>
        [JsiiProperty("maxLength", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MaxLength
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
    }
}