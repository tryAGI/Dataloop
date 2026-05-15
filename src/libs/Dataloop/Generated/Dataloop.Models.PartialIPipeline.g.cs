
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialIPipeline
    {
        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.PipelineTypeJsonConverter))]
        public global::Dataloop.PipelineType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        public string? OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminated")]
        public bool? Terminated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startNodes")]
        public global::System.Collections.Generic.IList<global::Dataloop.IStartNode>? StartNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        public object? Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compositionId")]
        public string? CompositionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public string? Preview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor>? Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connections")]
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection>? Connections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.TemplateKindJsonConverter))]
        public global::Dataloop.TemplateKind? TemplateKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAttempts")]
        public double? MaxAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resetTimestamp")]
        public global::System.DateTime? ResetTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textSearch")]
        public global::Dataloop.ITextSearch? TextSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CompositionStatusJsonConverter))]
        public global::Dataloop.CompositionStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Dataloop.IPipelineSettings? Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>? Variables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public global::Dataloop.PartialIPipelineTemplate? Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionNumber")]
        public double? VersionNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialIPipeline" /> class.
        /// </summary>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="name"></param>
        /// <param name="creator"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="type"></param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="terminated"></param>
        /// <param name="startNodes"></param>
        /// <param name="spec"></param>
        /// <param name="compositionId"></param>
        /// <param name="description"></param>
        /// <param name="preview"></param>
        /// <param name="nodes"></param>
        /// <param name="connections"></param>
        /// <param name="templateKind"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="resetTimestamp"></param>
        /// <param name="textSearch"></param>
        /// <param name="status"></param>
        /// <param name="settings"></param>
        /// <param name="variables"></param>
        /// <param name="template"></param>
        /// <param name="versionNumber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialIPipeline(
            string? id,
            string? name,
            string? creator,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? updatedBy,
            global::Dataloop.PipelineType? type,
            string? orgId,
            string? projectId,
            bool? terminated,
            global::System.Collections.Generic.IList<global::Dataloop.IStartNode>? startNodes,
            object? spec,
            string? compositionId,
            string? description,
            string? preview,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor>? nodes,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection>? connections,
            global::Dataloop.TemplateKind? templateKind,
            double? maxAttempts,
            global::System.DateTime? resetTimestamp,
            global::Dataloop.ITextSearch? textSearch,
            global::Dataloop.CompositionStatus? status,
            global::Dataloop.IPipelineSettings? settings,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>? variables,
            global::Dataloop.PartialIPipelineTemplate? template,
            double? versionNumber)
        {
            this.Id = id;
            this.Name = name;
            this.Creator = creator;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Type = type;
            this.OrgId = orgId;
            this.ProjectId = projectId;
            this.Terminated = terminated;
            this.StartNodes = startNodes;
            this.Spec = spec;
            this.CompositionId = compositionId;
            this.Description = description;
            this.Preview = preview;
            this.Nodes = nodes;
            this.Connections = connections;
            this.TemplateKind = templateKind;
            this.MaxAttempts = maxAttempts;
            this.ResetTimestamp = resetTimestamp;
            this.TextSearch = textSearch;
            this.Status = status;
            this.Settings = settings;
            this.Variables = variables;
            this.Template = template;
            this.VersionNumber = versionNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialIPipeline" /> class.
        /// </summary>
        public PartialIPipeline()
        {
        }

    }
}