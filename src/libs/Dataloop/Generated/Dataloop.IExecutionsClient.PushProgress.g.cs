#nullable enable

namespace Dataloop
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// Update Execution Progress.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Execution> PushProgressAsync(
            string id,

            global::Dataloop.PushProgressRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Execution Progress.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="duration"></param>
        /// <param name="packageRevision">
        /// package revision
        /// </param>
        /// <param name="serviceVersion">
        /// service version
        /// </param>
        /// <param name="output"></param>
        /// <param name="error"></param>
        /// <param name="percentComplete">
        /// percent work done
        /// </param>
        /// <param name="message">
        /// message
        /// </param>
        /// <param name="status"></param>
        /// <param name="timestamp"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Execution> PushProgressAsync(
            string id,
            double percentComplete,
            string message,
            global::Dataloop.ExecutionStatusName status,
            global::System.DateTime timestamp,
            double? duration = default,
            string? packageRevision = default,
            string? serviceVersion = default,
            global::Dataloop.Dictionary? output = default,
            string? error = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}