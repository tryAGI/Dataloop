#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.ListExportHistoryResponse> ListExportHistoryAsync(

            global::Dataloop.ListExportHistoryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortOrder"></param>
        /// <param name="sortBy"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageOffset"></param>
        /// <param name="exportId"></param>
        /// <param name="creator"></param>
        /// <param name="projects"></param>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.ListExportHistoryResponse> ListExportHistoryAsync(
            global::System.Collections.Generic.IList<string> projects,
            global::Dataloop.ListExportHistoryRequestSortOrder? sortOrder = default,
            global::Dataloop.ListExportHistoryRequestSortBy? sortBy = default,
            double? pageSize = default,
            double? pageOffset = default,
            string? exportId = default,
            string? creator = default,
            string? datasetId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}