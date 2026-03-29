
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloneDatasetRequest
    {
        /// <summary>
        /// Dataset name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DQLQuery Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloneDatasetParams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CloneDatasetParams CloneDatasetParams { get; set; }

        /// <summary>
        /// run as async
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnCmd")]
        public bool? ReturnCmd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public double? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexDriver")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DatasetIndexDriversJsonConverter))]
        public global::Dataloop.DatasetIndexDrivers? IndexDriver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowAnnotationDuplication")]
        public bool? AllowAnnotationDuplication { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDatasetRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Dataset name
        /// </param>
        /// <param name="filter"></param>
        /// <param name="cloneDatasetParams"></param>
        /// <param name="returnCmd">
        /// run as async
        /// </param>
        /// <param name="version"></param>
        /// <param name="indexDriver"></param>
        /// <param name="allowAnnotationDuplication"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloneDatasetRequest(
            string name,
            global::Dataloop.DQLQuery filter,
            global::Dataloop.CloneDatasetParams cloneDatasetParams,
            bool? returnCmd,
            double? version,
            global::Dataloop.DatasetIndexDrivers? indexDriver,
            bool? allowAnnotationDuplication)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.CloneDatasetParams = cloneDatasetParams ?? throw new global::System.ArgumentNullException(nameof(cloneDatasetParams));
            this.ReturnCmd = returnCmd;
            this.Version = version;
            this.IndexDriver = indexDriver;
            this.AllowAnnotationDuplication = allowAnnotationDuplication;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDatasetRequest" /> class.
        /// </summary>
        public CloneDatasetRequest()
        {
        }
    }
}