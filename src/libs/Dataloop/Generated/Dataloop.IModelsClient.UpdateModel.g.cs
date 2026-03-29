#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Update a Model<br/>
        /// Supply the unique id of the Model to update and an object describing which fields update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="system"></param>
        /// <param name="reloadServices"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIModel> UpdateModelAsync(
            string id,

            global::Dataloop.PatchModelRequest request,
            bool? system = default,
            bool? reloadServices = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Model<br/>
        /// Supply the unique id of the Model to update and an object describing which fields update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="system"></param>
        /// <param name="reloadServices"></param>
        /// <param name="name">
        /// The models name
        /// </param>
        /// <param name="description">
        /// description of the model
        /// </param>
        /// <param name="datasetId">
        /// The datasets id that the model is connected to
        /// </param>
        /// <param name="artifacts">
        /// the artifacts of the model<br/>
        /// an artifact indicates where the model binaries sit
        /// </param>
        /// <param name="scope">
        /// Field that shows the scope in which the model exists
        /// </param>
        /// <param name="status">
        /// the current models status
        /// </param>
        /// <param name="tags">
        /// Tags related to the model
        /// </param>
        /// <param name="labels">
        /// Labels related to the model
        /// </param>
        /// <param name="configuration">
        /// The configuration that the model was created with
        /// </param>
        /// <param name="inputType">
        /// Model Input Type
        /// </param>
        /// <param name="outputType">
        /// Model Output Type
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="moduleName">
        /// The module name of the model
        /// </param>
        /// <param name="app"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIModel> UpdateModelAsync(
            string id,
            bool? system = default,
            bool? reloadServices = default,
            string? name = default,
            string? description = default,
            string? datasetId = default,
            global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>? artifacts = default,
            global::Dataloop.EntityScopeLevel? scope = default,
            global::Dataloop.ModelStatus? status = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::Dataloop.APIModelConfiguration? configuration = default,
            global::Dataloop.ModelInputType? inputType = default,
            global::Dataloop.ModelOutputType? outputType = default,
            global::Dataloop.APIModelMetadata? metadata = default,
            string? moduleName = default,
            global::Dataloop.IAppDefinition? app = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}