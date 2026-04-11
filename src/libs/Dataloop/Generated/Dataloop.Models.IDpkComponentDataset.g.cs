
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkComponentDataset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mandatory")]
        public bool? Mandatory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docs")]
        public string? Docs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ontology")]
        public global::Dataloop.IDpkComponentDatasetOntology? Ontology { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoke")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IDpkComponentDatasetInvoke Invoke { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computeConfig")]
        public string? ComputeConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.Dictionary? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver")]
        public string? Driver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentDataset" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="invoke"></param>
        /// <param name="name"></param>
        /// <param name="mandatory"></param>
        /// <param name="docs"></param>
        /// <param name="ontology"></param>
        /// <param name="computeConfig"></param>
        /// <param name="description"></param>
        /// <param name="metadata"></param>
        /// <param name="driver"></param>
        /// <param name="driverId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkComponentDataset(
            string source,
            global::Dataloop.IDpkComponentDatasetInvoke invoke,
            string? name,
            bool? mandatory,
            string? docs,
            global::Dataloop.IDpkComponentDatasetOntology? ontology,
            string? computeConfig,
            string? description,
            global::Dataloop.Dictionary? metadata,
            string? driver,
            string? driverId)
        {
            this.Name = name;
            this.Mandatory = mandatory;
            this.Docs = docs;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Ontology = ontology;
            this.Invoke = invoke ?? throw new global::System.ArgumentNullException(nameof(invoke));
            this.ComputeConfig = computeConfig;
            this.Description = description;
            this.Metadata = metadata;
            this.Driver = driver;
            this.DriverId = driverId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentDataset" /> class.
        /// </summary>
        public IDpkComponentDataset()
        {
        }
    }
}