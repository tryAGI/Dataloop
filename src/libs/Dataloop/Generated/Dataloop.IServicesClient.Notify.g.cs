#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task NotifyAsync(
            string id,

            global::Dataloop.AgentNotificationPayload request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="action"></param>
        /// <param name="message"></param>
        /// <param name="notificationName"></param>
        /// <param name="notificationPath"></param>
        /// <param name="agentInfo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task NotifyAsync(
            string id,
            string action,
            string? message = default,
            string? notificationName = default,
            string? notificationPath = default,
            global::Dataloop.AgentNotificationPayloadAgentInfo? agentInfo = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}