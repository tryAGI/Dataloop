
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemaEntryInputVariant1
    {
        /// <summary>
        /// when true, schema will NOT be persisted to db
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipUpdate")]
        public bool? SkipUpdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaEntryInputVariant1" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="skipUpdate">
        /// when true, schema will NOT be persisted to db
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemaEntryInputVariant1(
            string key,
            bool? skipUpdate)
        {
            this.SkipUpdate = skipUpdate;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaEntryInputVariant1" /> class.
        /// </summary>
        public SchemaEntryInputVariant1()
        {
        }
    }
}