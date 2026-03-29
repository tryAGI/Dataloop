
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloneDatasetParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withItemsAnnotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WithItemsAnnotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withMetadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WithMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripItemsFolders")]
        public bool? StripItemsFolders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetDirectory")]
        public string? TargetDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetDatasetId")]
        public string? TargetDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowMany")]
        public bool? AllowMany { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newDatasetName")]
        public string? NewDatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexDriver")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DatasetIndexDriversJsonConverter))]
        public global::Dataloop.DatasetIndexDrivers? IndexDriver { get; set; }

        /// <summary>
        /// Clone the dataset event if it has more items then allowed limit. only super-user can specify this option
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreSizeLimit")]
        public bool? IgnoreSizeLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDatasetParams" /> class.
        /// </summary>
        /// <param name="withItemsAnnotations"></param>
        /// <param name="withMetadata"></param>
        /// <param name="stripItemsFolders"></param>
        /// <param name="targetDirectory"></param>
        /// <param name="targetDatasetId"></param>
        /// <param name="allowMany"></param>
        /// <param name="newDatasetName"></param>
        /// <param name="indexDriver"></param>
        /// <param name="ignoreSizeLimit">
        /// Clone the dataset event if it has more items then allowed limit. only super-user can specify this option
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloneDatasetParams(
            bool withItemsAnnotations,
            bool withMetadata,
            bool? stripItemsFolders,
            string? targetDirectory,
            string? targetDatasetId,
            bool? allowMany,
            string? newDatasetName,
            global::Dataloop.DatasetIndexDrivers? indexDriver,
            bool? ignoreSizeLimit)
        {
            this.WithItemsAnnotations = withItemsAnnotations;
            this.WithMetadata = withMetadata;
            this.StripItemsFolders = stripItemsFolders;
            this.TargetDirectory = targetDirectory;
            this.TargetDatasetId = targetDatasetId;
            this.AllowMany = allowMany;
            this.NewDatasetName = newDatasetName;
            this.IndexDriver = indexDriver;
            this.IgnoreSizeLimit = ignoreSizeLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDatasetParams" /> class.
        /// </summary>
        public CloneDatasetParams()
        {
        }
    }
}