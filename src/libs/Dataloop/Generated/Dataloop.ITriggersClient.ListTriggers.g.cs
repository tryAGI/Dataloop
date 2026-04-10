#nullable enable

namespace Dataloop
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Retrieves services.<br/>
        /// Supply query parameters to filter the list.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="projectsQuery"></param>
        /// <param name="resource"></param>
        /// <param name="active"></param>
        /// <param name="executionMode"></param>
        /// <param name="serviceId"></param>
        /// <param name="webhookId"></param>
        /// <param name="operationType"></param>
        /// <param name="entity"></param>
        /// <param name="action"></param>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.TriggersPage> ListTriggersAsync(
            global::Dataloop.TriggerType? type = default,
            string? name = default,
            string? projectsQuery = default,
            string? resource = default,
            bool? active = default,
            string? executionMode = default,
            string? serviceId = default,
            string? webhookId = default,
            string? operationType = default,
            string? entity = default,
            string? action = default,
            double? pageOffset = default,
            double? pageSize = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}