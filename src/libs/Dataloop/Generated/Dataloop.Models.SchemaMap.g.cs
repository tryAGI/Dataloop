
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemaMap
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Dataloop.SchemaEntry> Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unsearchablePaths")]
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.UnsearchableSchemaEntry>? UnsearchablePaths { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexing")]
        public string? Indexing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.SchemaModeJsonConverter))]
        public global::Dataloop.SchemaMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaMap" /> class.
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="version"></param>
        /// <param name="unsearchablePaths"></param>
        /// <param name="indexing">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemaMap(
            global::System.Collections.Generic.Dictionary<string, global::Dataloop.SchemaEntry> keys,
            double version,
            global::System.Collections.Generic.Dictionary<string, global::Dataloop.UnsearchableSchemaEntry>? unsearchablePaths,
            string? indexing,
            global::Dataloop.SchemaMode? mode)
        {
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
            this.UnsearchablePaths = unsearchablePaths;
            this.Indexing = indexing;
            this.Version = version;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaMap" /> class.
        /// </summary>
        public SchemaMap()
        {
        }
    }
}