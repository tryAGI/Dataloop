#nullable enable

namespace Dataloop
{
    public partial interface IAuditClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AuditLogsCursorPage> QueryAuditLogsAsync(

            global::Dataloop.QueryAuditLogsRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="descending"></param>
        /// <param name="sortBy"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="toDate"></param>
        /// <param name="fromDate"></param>
        /// <param name="user"></param>
        /// <param name="action"></param>
        /// <param name="entityName"></param>
        /// <param name="entityType"></param>
        /// <param name="id"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AuditLogsCursorPage> QueryAuditLogsAsync(
            string orgId,
            bool? descending = default,
            string? sortBy = default,
            double? pageSize = default,
            double? page = default,
            global::System.DateTime? toDate = default,
            global::System.DateTime? fromDate = default,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? user = default,
            string? action = default,
            string? entityName = default,
            string? entityType = default,
            string? id = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}