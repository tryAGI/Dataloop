
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrateDatasetsIndexOperationInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetItemsSchema")]
        public global::Dataloop.SchemaMap? TargetItemsSchema { get; set; }

        /// <summary>
        /// decides how many annotations can be migrated in a single batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationsBatchSize")]
        public double? AnnotationsBatchSize { get; set; }

        /// <summary>
        /// decides how many items can be migrated in a single batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsBatchSize")]
        public double? ItemsBatchSize { get; set; }

        /// <summary>
        /// decides how many migrate dataset commands can run at a single time @default 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public double? Concurrency { get; set; }

        /// <summary>
        /// deletes data in a target index before index migration to prevent data duplicating issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteTarget")]
        public bool? DeleteTarget { get; set; }

        /// <summary>
        /// deletes data in a source index after index migration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteSource")]
        public bool? DeleteSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetIndex")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DatasetIndexDriversJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DatasetIndexDrivers TargetIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetQuery")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DQLResourceQuery DatasetQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateDatasetsIndexOperationInput" /> class.
        /// </summary>
        /// <param name="targetIndex"></param>
        /// <param name="datasetQuery"></param>
        /// <param name="targetItemsSchema"></param>
        /// <param name="annotationsBatchSize">
        /// decides how many annotations can be migrated in a single batch
        /// </param>
        /// <param name="itemsBatchSize">
        /// decides how many items can be migrated in a single batch
        /// </param>
        /// <param name="concurrency">
        /// decides how many migrate dataset commands can run at a single time @default 10
        /// </param>
        /// <param name="deleteTarget">
        /// deletes data in a target index before index migration to prevent data duplicating issue
        /// </param>
        /// <param name="deleteSource">
        /// deletes data in a source index after index migration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MigrateDatasetsIndexOperationInput(
            global::Dataloop.DatasetIndexDrivers targetIndex,
            global::Dataloop.DQLResourceQuery datasetQuery,
            global::Dataloop.SchemaMap? targetItemsSchema,
            double? annotationsBatchSize,
            double? itemsBatchSize,
            double? concurrency,
            bool? deleteTarget,
            bool? deleteSource)
        {
            this.TargetItemsSchema = targetItemsSchema;
            this.AnnotationsBatchSize = annotationsBatchSize;
            this.ItemsBatchSize = itemsBatchSize;
            this.Concurrency = concurrency;
            this.DeleteTarget = deleteTarget;
            this.DeleteSource = deleteSource;
            this.TargetIndex = targetIndex;
            this.DatasetQuery = datasetQuery ?? throw new global::System.ArgumentNullException(nameof(datasetQuery));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateDatasetsIndexOperationInput" /> class.
        /// </summary>
        public MigrateDatasetsIndexOperationInput()
        {
        }
    }
}