
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeatureFlagsSet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultIndexDriver")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DatasetIndexDriversJsonConverter))]
        public global::Dataloop.DatasetIndexDrivers? DefaultIndexDriver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableDefaultDriver")]
        public bool? DisableDefaultDriver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extends")]
        public global::System.Collections.Generic.IList<string>? Extends { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FeatureFlagsSetContextVariant1, global::Dataloop.FeatureFlagsSetContextVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<global::Dataloop.FeatureFlagsSetContextVariant1, global::Dataloop.FeatureFlagsSetContextVariant2> Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlagsSet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="context"></param>
        /// <param name="defaultIndexDriver"></param>
        /// <param name="disableDefaultDriver"></param>
        /// <param name="extends"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeatureFlagsSet(
            string id,
            global::Dataloop.AnyOf<global::Dataloop.FeatureFlagsSetContextVariant1, global::Dataloop.FeatureFlagsSetContextVariant2> context,
            global::Dataloop.DatasetIndexDrivers? defaultIndexDriver,
            bool? disableDefaultDriver,
            global::System.Collections.Generic.IList<string>? extends)
        {
            this.DefaultIndexDriver = defaultIndexDriver;
            this.DisableDefaultDriver = disableDefaultDriver;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Extends = extends;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlagsSet" /> class.
        /// </summary>
        public FeatureFlagsSet()
        {
        }
    }
}