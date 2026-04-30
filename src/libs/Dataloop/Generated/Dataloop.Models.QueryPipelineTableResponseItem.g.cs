
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryPipelineTableResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionNumber")]
        public double? VersionNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public global::Dataloop.QueryPipelineTableResponseItemTemplate? Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resetTimestamp")]
        public global::System.DateTime? ResetTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>? Variables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Dataloop.IPipelineSettings? Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CompositionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CompositionStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startNodes")]
        public global::System.Collections.Generic.IList<global::Dataloop.IStartNode>? StartNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Preview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection> Connections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor> Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compositionId")]
        public string? CompositionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pendingCycles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object PendingCycles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastExecutionTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object LastExecutionTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryPipelineTableResponseItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="preview"></param>
        /// <param name="description"></param>
        /// <param name="connections"></param>
        /// <param name="nodes"></param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="id"></param>
        /// <param name="pendingCycles"></param>
        /// <param name="lastExecutionTime"></param>
        /// <param name="versionNumber"></param>
        /// <param name="template"></param>
        /// <param name="resetTimestamp"></param>
        /// <param name="variables"></param>
        /// <param name="settings"></param>
        /// <param name="startNodes"></param>
        /// <param name="compositionId"></param>
        /// <param name="updatedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryPipelineTableResponseItem(
            global::Dataloop.CompositionStatus status,
            string preview,
            string description,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection> connections,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor> nodes,
            string orgId,
            string projectId,
            global::System.DateTime updatedAt,
            global::System.DateTime createdAt,
            string creator,
            string name,
            string url,
            string id,
            object pendingCycles,
            object lastExecutionTime,
            double? versionNumber,
            global::Dataloop.QueryPipelineTableResponseItemTemplate? template,
            global::System.DateTime? resetTimestamp,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>? variables,
            global::Dataloop.IPipelineSettings? settings,
            global::System.Collections.Generic.IList<global::Dataloop.IStartNode>? startNodes,
            string? compositionId,
            string? updatedBy)
        {
            this.VersionNumber = versionNumber;
            this.Template = template;
            this.ResetTimestamp = resetTimestamp;
            this.Variables = variables;
            this.Settings = settings;
            this.Status = status;
            this.StartNodes = startNodes;
            this.Preview = preview ?? throw new global::System.ArgumentNullException(nameof(preview));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Connections = connections ?? throw new global::System.ArgumentNullException(nameof(connections));
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.CompositionId = compositionId;
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.UpdatedBy = updatedBy;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PendingCycles = pendingCycles ?? throw new global::System.ArgumentNullException(nameof(pendingCycles));
            this.LastExecutionTime = lastExecutionTime ?? throw new global::System.ArgumentNullException(nameof(lastExecutionTime));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryPipelineTableResponseItem" /> class.
        /// </summary>
        public QueryPipelineTableResponseItem()
        {
        }
    }
}