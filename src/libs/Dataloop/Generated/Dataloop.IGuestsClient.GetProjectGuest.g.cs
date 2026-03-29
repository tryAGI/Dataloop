#nullable enable

namespace Dataloop
{
    public partial interface IGuestsClient
    {
        /// <summary>
        /// Get information about a guest company in a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="guestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIProjectGuest> GetProjectGuestAsync(
            string projectId,
            string guestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}