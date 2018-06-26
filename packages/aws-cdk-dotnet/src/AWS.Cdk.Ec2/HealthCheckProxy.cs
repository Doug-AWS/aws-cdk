using AWS.Jsii.Runtime.Deputy;

namespace AWS.Cdk.Ec2
{
    /// <summary>Describe the health check to a load balancer</summary>
    [JsiiInterfaceProxy("@aws-cdk/ec2", "jsii$_aws_cdk_ec2$.HealthCheck")]
    public class HealthCheckProxy : DeputyBase, IHealthCheck
    {
        private HealthCheckProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>What port number to health check on</summary>
        [JsiiProperty("port", "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetProperty<double>();
            set => SetProperty(value);
        }

        /// <summary>
        /// What protocol to use for health checking
        /// 
        /// The protocol is automatically determined from the port if it's not supplied.
        /// </summary>
        /// <remarks>default: Automatic</remarks>
        [JsiiProperty("protocol", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Protocol
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>
        /// What path to use for HTTP or HTTPS health check (must return 200)
        /// 
        /// For SSL and TCP health checks, accepting connections is enough to be considered
        /// healthy.
        /// </summary>
        /// <remarks>default: "/"</remarks>
        [JsiiProperty("path", "{\"primitive\":\"string\",\"optional\":true}")]
        public virtual string Path
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        /// <summary>After how many successful checks is an instance considered healthy</summary>
        /// <remarks>default: 2</remarks>
        [JsiiProperty("healthyThreshold", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? HealthyThreshold
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>After how many unsuccessful checks is an instance considered unhealthy</summary>
        /// <remarks>default: 5</remarks>
        [JsiiProperty("unhealthyThreshold", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? UnhealthyThreshold
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>Number of seconds between health checks</summary>
        /// <remarks>default: 30</remarks>
        [JsiiProperty("interval", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? Interval
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        /// <summary>Health check timeout</summary>
        /// <remarks>default: 5</remarks>
        [JsiiProperty("timeout", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? Timeout
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }
    }
}