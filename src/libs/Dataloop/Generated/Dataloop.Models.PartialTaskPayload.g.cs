
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartialTaskPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        public string? RecipeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskOwner")]
        public string? TaskOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dueDate")]
        public double? DueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableActions")]
        public global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? AvailableActions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>))]
        public global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>? Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asynced")]
        public bool? Asynced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::Dataloop.PickDescriptionContent? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTaskPayload" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="recipeId"></param>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="creator"></param>
        /// <param name="taskOwner"></param>
        /// <param name="priority"></param>
        /// <param name="dueDate"></param>
        /// <param name="status"></param>
        /// <param name="availableActions"></param>
        /// <param name="spec"></param>
        /// <param name="asynced"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialTaskPayload(
            global::Dataloop.Dictionary metadata,
            string? recipeId,
            string? query,
            string? name,
            string? creator,
            string? taskOwner,
            double? priority,
            double? dueDate,
            string? status,
            global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? availableActions,
            global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>? spec,
            bool? asynced,
            global::Dataloop.PickDescriptionContent? description)
        {
            this.RecipeId = recipeId;
            this.Query = query;
            this.Name = name;
            this.Creator = creator;
            this.TaskOwner = taskOwner;
            this.Priority = priority;
            this.DueDate = dueDate;
            this.Status = status;
            this.AvailableActions = availableActions;
            this.Spec = spec;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Asynced = asynced;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTaskPayload" /> class.
        /// </summary>
        public PartialTaskPayload()
        {
        }
    }
}