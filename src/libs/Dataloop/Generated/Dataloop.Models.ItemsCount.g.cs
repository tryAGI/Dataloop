
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ItemsCount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalAnnotated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalAnnotated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsCount" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="totalAnnotated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemsCount(
            double total,
            double totalAnnotated)
        {
            this.Total = total;
            this.TotalAnnotated = totalAnnotated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsCount" /> class.
        /// </summary>
        public ItemsCount()
        {
        }
    }
}