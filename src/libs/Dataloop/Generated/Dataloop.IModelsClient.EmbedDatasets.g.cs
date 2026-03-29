#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Embed Datasets<br/>
        /// this will run embed on the datasets<br/>
        /// Provide the model ID of the Model to embed from<br/>
        /// Also provide the a list of dataset IDs to embed
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIModel, global::Dataloop.APICommand>> EmbedDatasetsAsync(
            string id,

            global::Dataloop.PartialAPIEmbedDatasetsSpec request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embed Datasets<br/>
        /// this will run embed on the datasets<br/>
        /// Provide the model ID of the Model to embed from<br/>
        /// Also provide the a list of dataset IDs to embed
        /// </summary>
        /// <param name="id"></param>
        /// <param name="datasetIds"></param>
        /// <param name="attachTrigger"></param>
        /// <param name="config"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIModel, global::Dataloop.APICommand>> EmbedDatasetsAsync(
            string id,
            global::System.Collections.Generic.IList<string>? datasetIds = default,
            bool? attachTrigger = default,
            global::Dataloop.PartialAPIEmbedDatasetsSpecConfig? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}