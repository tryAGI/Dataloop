#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Service debug stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="force"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIService> ServiceDebugAsync(
            string id,
            string force,

            global::Dataloop.DebugSession request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Service debug stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="force"></param>
        /// <param name="serveDebugIngressCreated">
        /// Server-only: set after first successful debug ingress create (ACTIVATE may poll frequently)
        /// </param>
        /// <param name="time"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIService> ServiceDebugAsync(
            string id,
            string force,
            global::Dataloop.EDebugOptionsStatus status,
            bool? serveDebugIngressCreated = default,
            global::System.DateTime? time = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}