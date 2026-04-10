#nullable enable

namespace Dataloop
{
    public partial interface IGuestsClient
    {
        /// <summary>
        /// Add an org to a guest company
        /// </summary>
        /// <param name="guestId"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIGuest> AddOrgToGuestAsync(
            string guestId,
            string projectId,

            global::Dataloop.AddOrgToGuestRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add an org to a guest company
        /// </summary>
        /// <param name="guestId"></param>
        /// <param name="projectId"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIGuest> AddOrgToGuestAsync(
            string guestId,
            string projectId,
            string orgId,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}