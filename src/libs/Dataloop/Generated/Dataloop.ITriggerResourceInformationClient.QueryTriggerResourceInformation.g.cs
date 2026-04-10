#nullable enable

namespace Dataloop
{
    public partial interface ITriggerResourceInformationClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.TriggerResourceInformationPage> QueryTriggerResourceInformationAsync(

            global::Dataloop.TriggerResourceInformationQuery request,
            double? pageOffset = default,
            double? pageSize = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="resource"></param>
        /// <param name="entity"></param>
        /// <param name="action"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.TriggerResourceInformationPage> QueryTriggerResourceInformationAsync(
            string resource,
            object entity,
            string action,
            double? pageOffset = default,
            double? pageSize = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}