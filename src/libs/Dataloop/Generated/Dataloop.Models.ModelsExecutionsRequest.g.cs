
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// The query
    /// </summary>
    public sealed partial class ModelsExecutionsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinFilter")]
        public global::Dataloop.Dictionary? JoinFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.QueryModel Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsExecutionsRequest" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="joinFilter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsExecutionsRequest(
            global::Dataloop.QueryModel query,
            global::Dataloop.Dictionary? joinFilter)
        {
            this.JoinFilter = joinFilter;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsExecutionsRequest" /> class.
        /// </summary>
        public ModelsExecutionsRequest()
        {
        }
    }
}