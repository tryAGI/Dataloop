#nullable enable

namespace Dataloop
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="system"></param>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>> EditDatasetItemAsync(
            string id,
            string datasetId,

            global::Dataloop.PartialAPIDatasetItem request,
            bool? system = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="system"></param>
        /// <param name="datasetId"></param>
        /// <param name="filename"></param>
        /// <param name="description"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>> EditDatasetItemAsync(
            string id,
            string datasetId,
            bool? system = default,
            string? filename = default,
            string? description = default,
            global::Dataloop.APISystemMetadata? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}