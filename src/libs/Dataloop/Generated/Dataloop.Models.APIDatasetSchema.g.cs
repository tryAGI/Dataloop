
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIDatasetSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.SchemaMap Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.SchemaMap Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIDatasetSchema" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="annotations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIDatasetSchema(
            global::Dataloop.SchemaMap items,
            global::Dataloop.SchemaMap annotations)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIDatasetSchema" /> class.
        /// </summary>
        public APIDatasetSchema()
        {
        }
    }
}