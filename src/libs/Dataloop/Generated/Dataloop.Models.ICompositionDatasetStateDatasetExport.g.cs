
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ICompositionDatasetStateDatasetExport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Json { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Zip { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionDatasetStateDatasetExport" /> class.
        /// </summary>
        /// <param name="json"></param>
        /// <param name="zip"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ICompositionDatasetStateDatasetExport(
            string json,
            string zip)
        {
            this.Json = json ?? throw new global::System.ArgumentNullException(nameof(json));
            this.Zip = zip ?? throw new global::System.ArgumentNullException(nameof(zip));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionDatasetStateDatasetExport" /> class.
        /// </summary>
        public ICompositionDatasetStateDatasetExport()
        {
        }
    }
}