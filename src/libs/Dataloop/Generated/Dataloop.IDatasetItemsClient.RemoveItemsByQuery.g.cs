#nullable enable

namespace Dataloop
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> RemoveItemsByQueryAsync(
            string datasetId,

            global::Dataloop.RemoveItemsByQueryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="filter"></param>
        /// <param name="join"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> RemoveItemsByQueryAsync(
            string datasetId,
            global::Dataloop.Dictionary filter,
            global::Dataloop.Dictionary join,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}