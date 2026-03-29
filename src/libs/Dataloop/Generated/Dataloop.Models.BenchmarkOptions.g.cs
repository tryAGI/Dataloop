
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BenchmarkOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.BenchmarkOptionsExportTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.BenchmarkOptionsExportType ExportType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulkSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BulkSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("childCommands")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ChildCommands { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarkOptions" /> class.
        /// </summary>
        /// <param name="exportType"></param>
        /// <param name="bulkSize"></param>
        /// <param name="childCommands"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BenchmarkOptions(
            global::Dataloop.BenchmarkOptionsExportType exportType,
            double bulkSize,
            double childCommands)
        {
            this.ExportType = exportType;
            this.BulkSize = bulkSize;
            this.ChildCommands = childCommands;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarkOptions" /> class.
        /// </summary>
        public BenchmarkOptions()
        {
        }
    }
}