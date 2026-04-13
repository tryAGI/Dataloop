
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The models name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// description of the model<br/>
        /// Default Value: My model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EntityScopeLevelJsonConverter))]
        public global::Dataloop.EntityScopeLevel? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ModelStatusJsonConverter))]
        public global::Dataloop.ModelStatus? Status { get; set; }

        /// <summary>
        /// Tags related to the model<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Labels related to the model<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::Dataloop.ModelConfiguration? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ModelInputTypeJsonConverter))]
        public global::Dataloop.ModelInputType? InputType { get; set; }

        /// <summary>
        /// 
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
        public global::System.Collections.Generic.IList<global::Dataloop.Dictionary>? Artifacts { get; set; }

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
        public string? ModuleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.Dictionary? Metadata { get; set; }

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
        /// Initializes a new instance of the <see cref="IModel" /> class.
        /// </summary>
        /// <param name="name">
        /// The models name
        /// </param>
        /// <param name="context"></param>
        /// <param name="id"></param>
        /// <param name="description">
        /// description of the model<br/>
        /// Default Value: My model
        /// </param>
        /// <param name="scope"></param>
        /// <param name="status"></param>
        /// <param name="tags">
        /// Tags related to the model<br/>
        /// Default Value: []
        /// </param>
        /// <param name="labels">
        /// Labels related to the model<br/>
        /// Default Value: []
        /// </param>
        /// <param name="configuration"></param>
        /// <param name="inputType"></param>
        /// <param name="outputType"></param>
        /// <param name="datasetId">
        /// The datasets id that the model is connected to
        /// </param>
        /// <param name="artifacts">
        /// the artifacts of the model<br/>
        /// an artifact indicates where the model binaries sit
        /// </param>
        /// <param name="moduleName">
        /// The module name of the model
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="app"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IModel(
            string name,
            global::Dataloop.EntityContext context,
            string? id,
            string? description,
            global::Dataloop.EntityScopeLevel? scope,
            global::Dataloop.ModelStatus? status,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? labels,
            global::Dataloop.ModelConfiguration? configuration,
            global::Dataloop.ModelInputType? inputType,
            global::Dataloop.ModelOutputType? outputType,
            string? datasetId,
            global::System.Collections.Generic.IList<global::Dataloop.Dictionary>? artifacts,
            string? moduleName,
            global::Dataloop.Dictionary? metadata,
            global::Dataloop.IAppDefinition? app)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Scope = scope;
            this.Status = status;
            this.Tags = tags;
            this.Labels = labels;
            this.Configuration = configuration;
            this.InputType = inputType;
            this.OutputType = outputType;
            this.DatasetId = datasetId;
            this.Artifacts = artifacts;
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.ModuleName = moduleName;
            this.Metadata = metadata;
            this.App = app;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IModel" /> class.
        /// </summary>
        public IModel()
        {
        }
    }
}