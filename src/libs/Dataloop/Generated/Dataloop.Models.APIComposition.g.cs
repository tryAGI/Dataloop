
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIComposition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// Array of services details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.APIServiceCompositionElement> Spec { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("terminated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Terminated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorText")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ICompositionError, string>))]
        public global::Dataloop.AnyOf<global::Dataloop.ICompositionError, string>? ErrorText { get; set; }

        /// <summary>
        /// Array of services details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionTrigger>? Triggers { get; set; }

        /// <summary>
        /// Array of packages details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionPackage>? Packages { get; set; }

        /// <summary>
        /// Array of tasks details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionTask>? Tasks { get; set; }

        /// <summary>
        /// Array of models details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::Dataloop.APICompositionModel>? Models { get; set; }

        /// <summary>
        /// Array of channels details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionChannel>? Channels { get; set; }

        /// <summary>
        /// Array of integrations ids - each one will be added to the service deployment as an environment variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<string>? Secrets { get; set; }

        /// <summary>
        /// Array of pipeline templates details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineTemplates")]
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionPipelineTemplate>? PipelineTemplates { get; set; }

        /// <summary>
        /// Array of datasets details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionDataset>? Datasets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIComposition" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <param name="creator"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="projectId"></param>
        /// <param name="orgId"></param>
        /// <param name="spec">
        /// Array of services details
        /// </param>
        /// <param name="status"></param>
        /// <param name="terminated"></param>
        /// <param name="errorText"></param>
        /// <param name="triggers">
        /// Array of services details
        /// </param>
        /// <param name="packages">
        /// Array of packages details
        /// </param>
        /// <param name="tasks">
        /// Array of tasks details
        /// </param>
        /// <param name="models">
        /// Array of models details
        /// </param>
        /// <param name="channels">
        /// Array of channels details
        /// </param>
        /// <param name="secrets">
        /// Array of integrations ids - each one will be added to the service deployment as an environment variable
        /// </param>
        /// <param name="pipelineTemplates">
        /// Array of pipeline templates details
        /// </param>
        /// <param name="datasets">
        /// Array of datasets details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIComposition(
            string id,
            string url,
            string name,
            string creator,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string projectId,
            string orgId,
            global::System.Collections.Generic.IList<global::Dataloop.APIServiceCompositionElement> spec,
            global::Dataloop.CompositionStatus status,
            bool terminated,
            global::Dataloop.AnyOf<global::Dataloop.ICompositionError, string>? errorText,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionTrigger>? triggers,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionPackage>? packages,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionTask>? tasks,
            global::System.Collections.Generic.IList<global::Dataloop.APICompositionModel>? models,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionChannel>? channels,
            global::System.Collections.Generic.IList<string>? secrets,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionPipelineTemplate>? pipelineTemplates,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionDataset>? datasets)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.Spec = spec ?? throw new global::System.ArgumentNullException(nameof(spec));
            this.Status = status;
            this.Terminated = terminated;
            this.ErrorText = errorText;
            this.Triggers = triggers;
            this.Packages = packages;
            this.Tasks = tasks;
            this.Models = models;
            this.Channels = channels;
            this.Secrets = secrets;
            this.PipelineTemplates = pipelineTemplates;
            this.Datasets = datasets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIComposition" /> class.
        /// </summary>
        public APIComposition()
        {
        }
    }
}