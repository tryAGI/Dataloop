
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeatureFlagsSetContextVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public object? Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant2TypeJsonConverter))]
        public global::Dataloop.FeatureFlagsSetContextVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlagsSetContextVariant2" /> class.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeatureFlagsSetContextVariant2(
            object? ids,
            global::Dataloop.FeatureFlagsSetContextVariant2Type type)
        {
            this.Ids = ids;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlagsSetContextVariant2" /> class.
        /// </summary>
        public FeatureFlagsSetContextVariant2()
        {
        }
    }
}