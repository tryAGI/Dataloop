#nullable enable

namespace Dataloop
{
    public partial interface IGuestsClient
    {
        /// <summary>
        /// Change a given guest company name of type
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="guestId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIGuest>> UpdateProjectGuestAsync(
            string projectId,
            string guestId,

            global::Dataloop.UpdateProjectGuestRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a given guest company name of type
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="guestId"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIGuest>> UpdateProjectGuestAsync(
            string projectId,
            string guestId,
            global::Dataloop.GuestType type,
            string name,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}