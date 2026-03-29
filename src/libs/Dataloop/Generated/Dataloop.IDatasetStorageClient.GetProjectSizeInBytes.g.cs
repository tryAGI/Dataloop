#nullable enable

namespace Dataloop
{
    public partial interface IDatasetStorageClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<double> GetProjectSizeInBytesAsync(

            global::Dataloop.ProjectStorageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="external"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<double> GetProjectSizeInBytesAsync(
            string projectId,
            bool external,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}