
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIUpdateStructurePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public global::System.Collections.Generic.IList<string>? Order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arcs")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Arcs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIUpdateStructurePayload" /> class.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="arcs"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIUpdateStructurePayload(
            global::System.Collections.Generic.IList<string>? order,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? arcs,
            string? name)
        {
            this.Order = order;
            this.Arcs = arcs;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIUpdateStructurePayload" /> class.
        /// </summary>
        public APIUpdateStructurePayload()
        {
        }
    }
}