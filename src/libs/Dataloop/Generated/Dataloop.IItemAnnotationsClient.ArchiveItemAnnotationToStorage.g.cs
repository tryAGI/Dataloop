#nullable enable

namespace Dataloop
{
    public partial interface IItemAnnotationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> ArchiveItemAnnotationToStorageAsync(
            string itemId,

            global::Dataloop.ArchiveItemAnnotationToStorageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="concurrency"></param>
        /// <param name="sampleSize"></param>
        /// <param name="spec"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> ArchiveItemAnnotationToStorageAsync(
            string itemId,
            double concurrency,
            double sampleSize,
            global::Dataloop.DQLResourceQuery spec,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}