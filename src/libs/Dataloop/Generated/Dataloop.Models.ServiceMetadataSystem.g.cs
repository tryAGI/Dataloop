
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceMetadataSystem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computeConsumptionMethod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EComputeConsumptionMethodJsonConverter))]
        public global::Dataloop.EComputeConsumptionMethod? ComputeConsumptionMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicConcurrency")]
        public bool? DynamicConcurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fetchExecutionsFromApi")]
        public bool? FetchExecutionsFromApi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceMetadataSystem" /> class.
        /// </summary>
        /// <param name="computeConsumptionMethod"></param>
        /// <param name="dynamicConcurrency"></param>
        /// <param name="fetchExecutionsFromApi"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceMetadataSystem(
            global::Dataloop.EComputeConsumptionMethod? computeConsumptionMethod,
            bool? dynamicConcurrency,
            bool? fetchExecutionsFromApi)
        {
            this.ComputeConsumptionMethod = computeConsumptionMethod;
            this.DynamicConcurrency = dynamicConcurrency;
            this.FetchExecutionsFromApi = fetchExecutionsFromApi;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceMetadataSystem" /> class.
        /// </summary>
        public ServiceMetadataSystem()
        {
        }
    }
}