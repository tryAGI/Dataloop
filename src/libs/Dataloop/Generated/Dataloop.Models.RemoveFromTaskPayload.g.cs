
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveFromTaskPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asynced")]
        public bool? Asynced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveFromTaskPayload" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="asynced"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveFromTaskPayload(
            string query,
            bool? asynced)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Asynced = asynced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveFromTaskPayload" /> class.
        /// </summary>
        public RemoveFromTaskPayload()
        {
        }
    }
}