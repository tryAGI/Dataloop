
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClonedItemSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ItemSpecTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ItemSpecType Type { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masterDatasetItemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MasterDatasetItemId { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentDatasetItemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParentDatasetItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetDriver")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetDriver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentDatasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParentDatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClonedItemSpec" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="masterDatasetItemId">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="parentDatasetItemId">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="datasetDriver"></param>
        /// <param name="parentDatasetId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClonedItemSpec(
            global::Dataloop.ItemSpecType type,
            string masterDatasetItemId,
            string parentDatasetItemId,
            string datasetDriver,
            string parentDatasetId)
        {
            this.Type = type;
            this.MasterDatasetItemId = masterDatasetItemId ?? throw new global::System.ArgumentNullException(nameof(masterDatasetItemId));
            this.ParentDatasetItemId = parentDatasetItemId ?? throw new global::System.ArgumentNullException(nameof(parentDatasetItemId));
            this.DatasetDriver = datasetDriver;
            this.ParentDatasetId = parentDatasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClonedItemSpec" /> class.
        /// </summary>
        public ClonedItemSpec()
        {
        }
    }
}