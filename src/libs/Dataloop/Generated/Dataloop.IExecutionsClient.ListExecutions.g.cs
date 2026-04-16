#nullable enable

namespace Dataloop
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// List service executions.
        /// </summary>
        /// <param name="projectsQuery"></param>
        /// <param name="service"></param>
        /// <param name="trigger"></param>
        /// <param name="functionName"></param>
        /// <param name="orderByType"></param>
        /// <param name="orderByDirection"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="status"></param>
        /// <param name="resourceType"></param>
        /// <param name="resourceId"></param>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.ExecutionsPage> ListExecutionsAsync(
            string? projectsQuery = default,
            string? service = default,
            string? trigger = default,
            string? functionName = default,
            global::Dataloop.ExecutionsOrderByType? orderByType = default,
            global::Dataloop.ExecutionsOrderByDirection? orderByDirection = default,
            string? createdAfter = default,
            string? createdBefore = default,
            global::Dataloop.ExecutionStatusName? status = default,
            global::Dataloop.PackageResourceType? resourceType = default,
            string? resourceId = default,
            double? pageOffset = default,
            double? pageSize = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}