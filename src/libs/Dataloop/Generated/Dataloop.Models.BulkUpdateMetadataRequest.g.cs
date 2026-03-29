
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateMetadataRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateQuery")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.UpdateItemMetadataOptions UpdateQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DQLResourceQuery Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMetadataRequest" /> class.
        /// </summary>
        /// <param name="updateQuery"></param>
        /// <param name="query"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateMetadataRequest(
            global::Dataloop.UpdateItemMetadataOptions updateQuery,
            global::Dataloop.DQLResourceQuery query)
        {
            this.UpdateQuery = updateQuery ?? throw new global::System.ArgumentNullException(nameof(updateQuery));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMetadataRequest" /> class.
        /// </summary>
        public BulkUpdateMetadataRequest()
        {
        }
    }
}