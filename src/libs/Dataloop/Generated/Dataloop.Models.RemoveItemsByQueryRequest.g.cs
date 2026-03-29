
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveItemsByQueryRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("join")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Join { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveItemsByQueryRequest" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="join"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveItemsByQueryRequest(
            global::Dataloop.Dictionary filter,
            global::Dataloop.Dictionary join)
        {
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Join = join ?? throw new global::System.ArgumentNullException(nameof(join));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveItemsByQueryRequest" /> class.
        /// </summary>
        public RemoveItemsByQueryRequest()
        {
        }
    }
}