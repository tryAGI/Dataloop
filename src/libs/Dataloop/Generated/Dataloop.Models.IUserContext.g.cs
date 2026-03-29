
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IUserContext
    {
        /// <summary>
        /// ID of the User
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// ID of the Org
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        public string? OrgId { get; set; }

        /// <summary>
        /// ID of the Project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// ID of the Task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        public string? TaskId { get; set; }

        /// <summary>
        /// ID of the Dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IUserContext" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the User
        /// </param>
        /// <param name="orgId">
        /// ID of the Org
        /// </param>
        /// <param name="projectId">
        /// ID of the Project
        /// </param>
        /// <param name="taskId">
        /// ID of the Task
        /// </param>
        /// <param name="datasetId">
        /// ID of the Dataset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IUserContext(
            string userId,
            string? orgId,
            string? projectId,
            string? taskId,
            string? datasetId)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.OrgId = orgId;
            this.ProjectId = projectId;
            this.TaskId = taskId;
            this.DatasetId = datasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IUserContext" /> class.
        /// </summary>
        public IUserContext()
        {
        }
    }
}