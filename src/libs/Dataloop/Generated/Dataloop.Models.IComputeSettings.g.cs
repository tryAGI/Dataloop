
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IComputeSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumptionMethod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EComputeConsumptionMethodJsonConverter))]
        public global::Dataloop.EComputeConsumptionMethod? ConsumptionMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultNamespace")]
        public string? DefaultNamespace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputeSettings" /> class.
        /// </summary>
        /// <param name="consumptionMethod"></param>
        /// <param name="defaultNamespace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IComputeSettings(
            global::Dataloop.EComputeConsumptionMethod? consumptionMethod,
            string? defaultNamespace)
        {
            this.ConsumptionMethod = consumptionMethod;
            this.DefaultNamespace = defaultNamespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputeSettings" /> class.
        /// </summary>
        public IComputeSettings()
        {
        }
    }
}