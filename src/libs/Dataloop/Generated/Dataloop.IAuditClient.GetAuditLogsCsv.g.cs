#nullable enable

namespace Dataloop
{
    public partial interface IAuditClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="id"></param>
        /// <param name="entityType"></param>
        /// <param name="entityName"></param>
        /// <param name="entityId"></param>
        /// <param name="action"></param>
        /// <param name="user"></param>
        /// <param name="sortBy"></param>
        /// <param name="descending"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAuditLogsCsvAsync(
            string orgId,
            global::System.DateTime fromDate,
            global::System.DateTime toDate,
            string? id = default,
            string? entityType = default,
            string? entityName = default,
            string? entityId = default,
            string? action = default,
            string? user = default,
            string? sortBy = default,
            string? descending = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}