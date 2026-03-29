
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MergeDatasetsRequest
    {
        /// <summary>
        /// Dataset name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// datasets id's
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetsIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DatasetsIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mergeDatasetParams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.MergeDatasetParams MergeDatasetParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeDatasetsRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Dataset name
        /// </param>
        /// <param name="datasetsIds">
        /// datasets id's
        /// </param>
        /// <param name="mergeDatasetParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MergeDatasetsRequest(
            string name,
            global::System.Collections.Generic.IList<string> datasetsIds,
            global::Dataloop.MergeDatasetParams mergeDatasetParams)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DatasetsIds = datasetsIds ?? throw new global::System.ArgumentNullException(nameof(datasetsIds));
            this.MergeDatasetParams = mergeDatasetParams ?? throw new global::System.ArgumentNullException(nameof(mergeDatasetParams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeDatasetsRequest" /> class.
        /// </summary>
        public MergeDatasetsRequest()
        {
        }
    }
}