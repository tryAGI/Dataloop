
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelRequest
    {
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
        public string? Description { get; set; }

        /// <summary>
        /// the id of the project the model belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Field that shows the scope in which the model exists<br/>
        /// default 'project'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EntityScopeLevelJsonConverter))]
        public global::Dataloop.EntityScopeLevel? Scope { get; set; }

        /// <summary>
        /// the current models status<br/>
        /// default ModelStatus.CREATED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ModelStatusJsonConverter))]
        public global::Dataloop.ModelStatus? Status { get; set; }

        /// <summary>
        /// Tags related to the model<br/>
        /// default []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Labels related to the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// The configuration that the model was created with<br/>
        /// default {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::Dataloop.APIModelConfiguration? Configuration { get; set; }

        /// <summary>
        /// Model Input Type<br/>
        /// default ModelInputType.IMAGE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ModelInputTypeJsonConverter))]
        public global::Dataloop.ModelInputType? InputType { get; set; }

        /// <summary>
        /// Model Output Type<br/>
        /// default AnnotationType.BOX
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ModelOutputTypeJsonConverter))]
        public global::Dataloop.ModelOutputType? OutputType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.APIModelMetadata? Metadata { get; set; }

        /// <summary>
        /// The module name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moduleName")]
        public string? ModuleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::Dataloop.IAppDefinition? App { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The models name
        /// </param>
        /// <param name="packageId">
        /// The model this model is derived from
        /// </param>
        /// <param name="projectId">
        /// the id of the project the model belongs to
        /// </param>
        /// <param name="description">
        /// description of the model<br/>
        /// default 'My model'
        /// </param>
        /// <param name="scope">
        /// Field that shows the scope in which the model exists<br/>
        /// default 'project'
        /// </param>
        /// <param name="status">
        /// the current models status<br/>
        /// default ModelStatus.CREATED
        /// </param>
        /// <param name="tags">
        /// Tags related to the model<br/>
        /// default []
        /// </param>
        /// <param name="labels">
        /// Labels related to the model
        /// </param>
        /// <param name="configuration">
        /// The configuration that the model was created with<br/>
        /// default {}
        /// </param>
        /// <param name="inputType">
        /// Model Input Type<br/>
        /// default ModelInputType.IMAGE
        /// </param>
        /// <param name="outputType">
        /// Model Output Type<br/>
        /// default AnnotationType.BOX
        /// </param>
        /// <param name="datasetId">
        /// The datasets id that the model is connected to
        /// </param>
        /// <param name="artifacts">
        /// the artifacts of the model<br/>
        /// an artifact indicates where the model binaries sit
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="moduleName">
        /// The module name of the model
        /// </param>
        /// <param name="app"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelRequest(
            string name,
            string packageId,
            string projectId,
            string? description,
            global::Dataloop.EntityScopeLevel? scope,
            global::Dataloop.ModelStatus? status,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? labels,
            global::Dataloop.APIModelConfiguration? configuration,
            global::Dataloop.ModelInputType? inputType,
            global::Dataloop.ModelOutputType? outputType,
            string? datasetId,
            global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>? artifacts,
            global::Dataloop.APIModelMetadata? metadata,
            string? moduleName,
            global::Dataloop.IAppDefinition? app)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PackageId = packageId ?? throw new global::System.ArgumentNullException(nameof(packageId));
            this.Description = description;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Scope = scope;
            this.Status = status;
            this.Tags = tags;
            this.Labels = labels;
            this.Configuration = configuration;
            this.InputType = inputType;
            this.OutputType = outputType;
            this.DatasetId = datasetId;
            this.Artifacts = artifacts;
            this.Metadata = metadata;
            this.ModuleName = moduleName;
            this.App = app;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        public CreateModelRequest()
        {
        }
    }
}