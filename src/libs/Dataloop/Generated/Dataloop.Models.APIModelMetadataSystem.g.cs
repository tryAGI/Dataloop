
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIModelMetadataSystem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ontologyId")]
        public string? OntologyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train")]
        public global::Dataloop.ModelOperationMetadata? Train { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predict")]
        public global::Dataloop.ModelOperationMetadata? Predict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluate")]
        public global::Dataloop.ModelOperationMetadata? Evaluate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploy")]
        public global::Dataloop.ModelOperationMetadata? Deploy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subsets")]
        public global::Dataloop.APIModelMetadataSubsets? Subsets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationsSubsets")]
        public global::Dataloop.APIModelMetadataAnnotationsSubsets? AnnotationsSubsets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refs")]
        public global::System.Collections.Generic.IList<global::Dataloop.EntityReference>? Refs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mlType")]
        public global::Dataloop.APIModelMetadataSystemMlType? MlType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloneCommand")]
        public global::Dataloop.APIModelMetadataSystemCloneCommand? CloneCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedDatasets")]
        public global::Dataloop.APIModelMetadataSystemEmbedDatasets? EmbedDatasets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reloadServices")]
        public global::Dataloop.APIModelMetadataSystemReloadServices? ReloadServices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIModelMetadataSystem" /> class.
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="ontologyId"></param>
        /// <param name="train"></param>
        /// <param name="predict"></param>
        /// <param name="evaluate"></param>
        /// <param name="deploy"></param>
        /// <param name="subsets"></param>
        /// <param name="annotationsSubsets"></param>
        /// <param name="refs"></param>
        /// <param name="mlType"></param>
        /// <param name="cloneCommand"></param>
        /// <param name="embedDatasets"></param>
        /// <param name="reloadServices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIModelMetadataSystem(
            bool? archived,
            string? ontologyId,
            global::Dataloop.ModelOperationMetadata? train,
            global::Dataloop.ModelOperationMetadata? predict,
            global::Dataloop.ModelOperationMetadata? evaluate,
            global::Dataloop.ModelOperationMetadata? deploy,
            global::Dataloop.APIModelMetadataSubsets? subsets,
            global::Dataloop.APIModelMetadataAnnotationsSubsets? annotationsSubsets,
            global::System.Collections.Generic.IList<global::Dataloop.EntityReference>? refs,
            global::Dataloop.APIModelMetadataSystemMlType? mlType,
            global::Dataloop.APIModelMetadataSystemCloneCommand? cloneCommand,
            global::Dataloop.APIModelMetadataSystemEmbedDatasets? embedDatasets,
            global::Dataloop.APIModelMetadataSystemReloadServices? reloadServices)
        {
            this.Archived = archived;
            this.OntologyId = ontologyId;
            this.Train = train;
            this.Predict = predict;
            this.Evaluate = evaluate;
            this.Deploy = deploy;
            this.Subsets = subsets;
            this.AnnotationsSubsets = annotationsSubsets;
            this.Refs = refs;
            this.MlType = mlType;
            this.CloneCommand = cloneCommand;
            this.EmbedDatasets = embedDatasets;
            this.ReloadServices = reloadServices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIModelMetadataSystem" /> class.
        /// </summary>
        public APIModelMetadataSystem()
        {
        }
    }
}