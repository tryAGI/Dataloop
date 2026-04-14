#nullable enable

namespace Dataloop
{
    public partial interface IDpkClient
    {
        /// <summary>
        /// Update existing dpk.<br/>
        /// The server will update dpk specified by id with the new dpk attributes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.UpdateResponse> UpdateAsync(
            string id,

            global::Dataloop.APIPatchDpk request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update existing dpk.<br/>
        /// The server will update dpk specified by id with the new dpk attributes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="attributes">
        /// List of attributes linked to the app
        /// </param>
        /// <param name="displayName">
        /// The display Name
        /// </param>
        /// <param name="description">
        /// description of the dpk
        /// </param>
        /// <param name="icon">
        /// icon style - should present in the ui platform
        /// </param>
        /// <param name="components"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.UpdateResponse> UpdateAsync(
            string id,
            object? attributes = default,
            string? displayName = default,
            string? description = default,
            string? icon = default,
            global::Dataloop.PreviewsComponentsPatch? components = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}