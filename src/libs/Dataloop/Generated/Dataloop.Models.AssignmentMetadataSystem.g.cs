
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignmentMetadataSystem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsAmountGoal")]
        public double? ItemsAmountGoal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markForDeletion")]
        public bool? MarkForDeletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive")]
        public bool? Archive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultAssignment")]
        public bool? DefaultAssignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensusAssignment")]
        public bool? ConsensusAssignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueAssignment")]
        public bool? QueueAssignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AssignmentMetadataSystemTypeJsonConverter))]
        public global::Dataloop.AssignmentMetadataSystemType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dueDate")]
        public double? DueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentMetadataSystem" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="datasetId"></param>
        /// <param name="itemsAmountGoal"></param>
        /// <param name="markForDeletion"></param>
        /// <param name="archive"></param>
        /// <param name="active"></param>
        /// <param name="defaultAssignment"></param>
        /// <param name="consensusAssignment"></param>
        /// <param name="queueAssignment"></param>
        /// <param name="hidden"></param>
        /// <param name="type"></param>
        /// <param name="dueDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignmentMetadataSystem(
            string taskId,
            string datasetId,
            double? itemsAmountGoal,
            bool? markForDeletion,
            bool? archive,
            bool? active,
            bool? defaultAssignment,
            bool? consensusAssignment,
            bool? queueAssignment,
            bool? hidden,
            global::Dataloop.AssignmentMetadataSystemType? type,
            double? dueDate)
        {
            this.ItemsAmountGoal = itemsAmountGoal;
            this.MarkForDeletion = markForDeletion;
            this.Archive = archive;
            this.Active = active;
            this.DefaultAssignment = defaultAssignment;
            this.ConsensusAssignment = consensusAssignment;
            this.QueueAssignment = queueAssignment;
            this.Hidden = hidden;
            this.Type = type;
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.DueDate = dueDate;
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentMetadataSystem" /> class.
        /// </summary>
        public AssignmentMetadataSystem()
        {
        }
    }
}