#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Restore a dataset marked for deletion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<double> RestoreDatasetAsync(

            global::Dataloop.RestoreDatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore a dataset marked for deletion
        /// </summary>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<double> RestoreDatasetAsync(
            global::Dataloop.DQLResourceQuery query,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}