#nullable enable

namespace Dataloop
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// Move files to a specified directory
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> MoveItemsAsync(
            string datasetId,
            string id,

            global::Dataloop.AnyOf<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.IList<string>> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move files to a specified directory
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> MoveItemsAsync(
            string datasetId,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}