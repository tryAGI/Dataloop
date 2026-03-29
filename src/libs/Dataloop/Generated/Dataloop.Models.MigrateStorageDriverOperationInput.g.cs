
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrateStorageDriverOperationInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketCreatingWaitingTime")]
        public double? BucketCreatingWaitingTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("miniItemsBatchSize")]
        public double? MiniItemsBatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectsConcurrency")]
        public double? ProjectsConcurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetsConcurrency")]
        public double? DatasetsConcurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsBatchSize")]
        public double? ItemsBatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteFromSource")]
        public bool? DeleteFromSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waitToCompletion")]
        public bool? WaitToCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Dataloop.DQLResourceQuery? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetDriverId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetDriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceDriverId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceDriverId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateStorageDriverOperationInput" /> class.
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="targetDriverId"></param>
        /// <param name="sourceDriverId"></param>
        /// <param name="bucketCreatingWaitingTime"></param>
        /// <param name="miniItemsBatchSize"></param>
        /// <param name="projectsConcurrency"></param>
        /// <param name="datasetsConcurrency"></param>
        /// <param name="itemsBatchSize"></param>
        /// <param name="deleteFromSource"></param>
        /// <param name="waitToCompletion"></param>
        /// <param name="filter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MigrateStorageDriverOperationInput(
            global::System.Collections.Generic.IList<string> projects,
            string targetDriverId,
            string sourceDriverId,
            double? bucketCreatingWaitingTime,
            double? miniItemsBatchSize,
            double? projectsConcurrency,
            double? datasetsConcurrency,
            double? itemsBatchSize,
            bool? deleteFromSource,
            bool? waitToCompletion,
            global::Dataloop.DQLResourceQuery? filter)
        {
            this.BucketCreatingWaitingTime = bucketCreatingWaitingTime;
            this.MiniItemsBatchSize = miniItemsBatchSize;
            this.ProjectsConcurrency = projectsConcurrency;
            this.DatasetsConcurrency = datasetsConcurrency;
            this.ItemsBatchSize = itemsBatchSize;
            this.DeleteFromSource = deleteFromSource;
            this.WaitToCompletion = waitToCompletion;
            this.Filter = filter;
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.TargetDriverId = targetDriverId;
            this.SourceDriverId = sourceDriverId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateStorageDriverOperationInput" /> class.
        /// </summary>
        public MigrateStorageDriverOperationInput()
        {
        }
    }
}