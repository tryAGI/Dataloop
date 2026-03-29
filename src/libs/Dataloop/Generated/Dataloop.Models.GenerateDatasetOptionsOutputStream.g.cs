
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateDatasetOptionsOutputStream
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Dataloop.PickDataStreamConfigAnyMaxConcurrentReadersOrRetentionOrCompression? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recreate")]
        public bool? Recreate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDatasetOptionsOutputStream" /> class.
        /// </summary>
        /// <param name="config">
        /// From T, pick a set of properties whose keys are in the union K
        /// </param>
        /// <param name="recreate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateDatasetOptionsOutputStream(
            global::Dataloop.PickDataStreamConfigAnyMaxConcurrentReadersOrRetentionOrCompression? config,
            bool? recreate)
        {
            this.Config = config;
            this.Recreate = recreate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDatasetOptionsOutputStream" /> class.
        /// </summary>
        public GenerateDatasetOptionsOutputStream()
        {
        }
    }
}