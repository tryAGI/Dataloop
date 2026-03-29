
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaasUsageServiceInstanceDescriptor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instanceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.PodTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.PodType InstanceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Sum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Hours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ServiceTypeJsonConverter))]
        public global::Dataloop.ServiceType? ServiceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preemptible")]
        public bool? Preemptible { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaasUsageServiceInstanceDescriptor" /> class.
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="serviceName"></param>
        /// <param name="instanceType"></param>
        /// <param name="sum"></param>
        /// <param name="hours"></param>
        /// <param name="serviceType"></param>
        /// <param name="driverId"></param>
        /// <param name="cost"></param>
        /// <param name="preemptible"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaasUsageServiceInstanceDescriptor(
            string serviceId,
            string serviceName,
            global::Dataloop.PodType instanceType,
            double sum,
            double hours,
            global::Dataloop.ServiceType? serviceType,
            string? driverId,
            double? cost,
            bool? preemptible)
        {
            this.ServiceId = serviceId ?? throw new global::System.ArgumentNullException(nameof(serviceId));
            this.ServiceName = serviceName ?? throw new global::System.ArgumentNullException(nameof(serviceName));
            this.InstanceType = instanceType;
            this.Sum = sum;
            this.Hours = hours;
            this.ServiceType = serviceType;
            this.DriverId = driverId;
            this.Cost = cost;
            this.Preemptible = preemptible;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaasUsageServiceInstanceDescriptor" /> class.
        /// </summary>
        public FaasUsageServiceInstanceDescriptor()
        {
        }
    }
}