#nullable enable

namespace Dataloop
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIAlert>> ListAccountAlertsAsync(
            string id,

            global::Dataloop.ListAccountAlertsRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sort"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="tier"></param>
        /// <param name="code"></param>
        /// <param name="status"></param>
        /// <param name="orgId"></param>
        /// <param name="accountId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="requestId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIAlert>> ListAccountAlertsAsync(
            string id,
            global::Dataloop.FieldSort? sort = default,
            double? pageSize = default,
            double? page = default,
            global::Dataloop.AlertTier? tier = default,
            string? code = default,
            global::Dataloop.AlertStatus? status = default,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? orgId = default,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? accountId = default,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? subscriptionId = default,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? requestId = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}