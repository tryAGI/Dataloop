
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CleanDatasetsDataSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexDriver")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DatasetIndexDriversJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DatasetIndexDrivers IndexDriver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetsQuery")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DQLResourceQuery DatasetsQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CleanDatasetsDataSpec" /> class.
        /// </summary>
        /// <param name="indexDriver"></param>
        /// <param name="datasetsQuery"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CleanDatasetsDataSpec(
            global::Dataloop.DatasetIndexDrivers indexDriver,
            global::Dataloop.DQLResourceQuery datasetsQuery)
        {
            this.IndexDriver = indexDriver;
            this.DatasetsQuery = datasetsQuery ?? throw new global::System.ArgumentNullException(nameof(datasetsQuery));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CleanDatasetsDataSpec" /> class.
        /// </summary>
        public CleanDatasetsDataSpec()
        {
        }
    }
}