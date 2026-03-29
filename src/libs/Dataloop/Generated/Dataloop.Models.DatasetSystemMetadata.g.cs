
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetSystemMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<string, global::Dataloop.SystemDatasetType?>))]
        public global::Dataloop.AllOf<string, global::Dataloop.SystemDatasetType?>? DatasetType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etlOptions")]
        public global::Dataloop.DatasetEtlOptions? EtlOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DatasetScopeJsonConverter))]
        public global::Dataloop.DatasetScope? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemCollectionsVersion")]
        public double? ItemCollectionsVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.CollectionEntry>? Collections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemCollectionsDeleteCommandId")]
        public string? ItemCollectionsDeleteCommandId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipes")]
        public global::System.Collections.Generic.IList<string>? Recipes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSystemMetadata" /> class.
        /// </summary>
        /// <param name="datasetType"></param>
        /// <param name="etlOptions"></param>
        /// <param name="scope"></param>
        /// <param name="itemCollectionsVersion"></param>
        /// <param name="collections"></param>
        /// <param name="itemCollectionsDeleteCommandId"></param>
        /// <param name="recipes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetSystemMetadata(
            global::Dataloop.AllOf<string, global::Dataloop.SystemDatasetType?>? datasetType,
            global::Dataloop.DatasetEtlOptions? etlOptions,
            global::Dataloop.DatasetScope? scope,
            double? itemCollectionsVersion,
            global::System.Collections.Generic.Dictionary<string, global::Dataloop.CollectionEntry>? collections,
            string? itemCollectionsDeleteCommandId,
            global::System.Collections.Generic.IList<string>? recipes)
        {
            this.DatasetType = datasetType;
            this.EtlOptions = etlOptions;
            this.Scope = scope;
            this.ItemCollectionsVersion = itemCollectionsVersion;
            this.Collections = collections;
            this.ItemCollectionsDeleteCommandId = itemCollectionsDeleteCommandId;
            this.Recipes = recipes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSystemMetadata" /> class.
        /// </summary>
        public DatasetSystemMetadata()
        {
        }
    }
}