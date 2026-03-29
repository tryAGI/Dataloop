
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIModel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// The models name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The model this model is derived from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageId { get; set; }

        /// <summary>
        /// description of the model<br/>
        /// default 'My model'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EntityScopeLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.EntityScopeLevel Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ModelStatus Status { get; set; }

        /// <summary>
        /// Tags related to the model<br/>
        /// default []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Labels related to the model<br/>
        /// default []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APIModelConfiguration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ModelInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ModelInputType InputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ModelOutputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ModelOutputType OutputType { get; set; }

        /// <summary>
        /// The datasets id that the model is connected to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// the artifacts of the model<br/>
        /// an artifact indicates where the model binaries sit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts")]
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>? Artifacts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.EntityContext Context { get; set; }

        /// <summary>
        /// The module name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moduleName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModuleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.APIModelMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::Dataloop.IAppDefinition? App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusLogs")]
        public global::System.Collections.Generic.IList<global::Dataloop.ModelStatusLog>? StatusLogs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="name">
        /// The models name
        /// </param>
        /// <param name="packageId">
        /// The model this model is derived from
        /// </param>
        /// <param name="description">
        /// description of the model<br/>
        /// default 'My model'
        /// </param>
        /// <param name="scope"></param>
        /// <param name="status"></param>
        /// <param name="tags">
        /// Tags related to the model<br/>
        /// default []
        /// </param>
        /// <param name="labels">
        /// Labels related to the model<br/>
        /// default []
        /// </param>
        /// <param name="configuration"></param>
        /// <param name="inputType"></param>
        /// <param name="outputType"></param>
        /// <param name="context"></param>
        /// <param name="moduleName">
        /// The module name of the model
        /// </param>
        /// <param name="updatedBy"></param>
        /// <param name="datasetId">
        /// The datasets id that the model is connected to
        /// </param>
        /// <param name="artifacts">
        /// the artifacts of the model<br/>
        /// an artifact indicates where the model binaries sit
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="app"></param>
        /// <param name="statusLogs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIModel(
            string id,
            string url,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string name,
            string packageId,
            string description,
            global::Dataloop.EntityScopeLevel scope,
            global::Dataloop.ModelStatus status,
            global::System.Collections.Generic.IList<string> tags,
            global::System.Collections.Generic.IList<string> labels,
            global::Dataloop.APIModelConfiguration configuration,
            global::Dataloop.ModelInputType inputType,
            global::Dataloop.ModelOutputType outputType,
            global::Dataloop.EntityContext context,
            string moduleName,
            string? updatedBy,
            string? datasetId,
            global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>? artifacts,
            global::Dataloop.APIModelMetadata? metadata,
            global::Dataloop.IAppDefinition? app,
            global::System.Collections.Generic.IList<global::Dataloop.ModelStatusLog>? statusLogs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PackageId = packageId ?? throw new global::System.ArgumentNullException(nameof(packageId));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Scope = scope;
            this.Status = status;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.InputType = inputType;
            this.OutputType = outputType;
            this.DatasetId = datasetId;
            this.Artifacts = artifacts;
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.ModuleName = moduleName ?? throw new global::System.ArgumentNullException(nameof(moduleName));
            this.Metadata = metadata;
            this.App = app;
            this.StatusLogs = statusLogs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIModel" /> class.
        /// </summary>
        public APIModel()
        {
        }
    }
}