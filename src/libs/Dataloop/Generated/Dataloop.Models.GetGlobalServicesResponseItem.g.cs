
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGlobalServicesResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Global { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGlobalServicesResponseItem" /> class.
        /// </summary>
        /// <param name="global"></param>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetGlobalServicesResponseItem(
            bool global,
            string id)
        {
            this.Global = global;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGlobalServicesResponseItem" /> class.
        /// </summary>
        public GetGlobalServicesResponseItem()
        {
        }
    }
}