#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Creates a new Model.<br/>
        /// Supply the appropriate Create Request object in order to create a Model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIModel> CreateModelAsync(

            global::Dataloop.CreateModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new Model.<br/>
        /// Supply the appropriate Create Request object in order to create a Model.
        /// </summary>
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
        /// <param name="projectId">
        /// the id of the project the model belongs to
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIModel> CreateModelAsync(
            string name,
            string packageId,
            string projectId,
            string? description = default,
            global::Dataloop.EntityScopeLevel? scope = default,
            global::Dataloop.ModelStatus? status = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::Dataloop.APIModelConfiguration? configuration = default,
            global::Dataloop.ModelInputType? inputType = default,
            global::Dataloop.ModelOutputType? outputType = default,
            string? datasetId = default,
            global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>? artifacts = default,
            global::Dataloop.APIModelMetadata? metadata = default,
            string? moduleName = default,
            global::Dataloop.IAppDefinition? app = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}