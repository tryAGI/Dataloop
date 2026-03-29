
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MoveItemsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dqlQuery")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DQLResourceQuery DqlQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveItemsRequest" /> class.
        /// </summary>
        /// <param name="dqlQuery"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MoveItemsRequest(
            global::Dataloop.DQLResourceQuery dqlQuery)
        {
            this.DqlQuery = dqlQuery ?? throw new global::System.ArgumentNullException(nameof(dqlQuery));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveItemsRequest" /> class.
        /// </summary>
        public MoveItemsRequest()
        {
        }
    }
}