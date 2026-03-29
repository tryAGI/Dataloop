#nullable enable

namespace Dataloop
{
    public partial interface IGuestsClient
    {
        /// <summary>
        /// Create a guest company in a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIGuest>> CreateProjectGuestAsync(
            string projectId,

            global::Dataloop.CreateGuestPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a guest company in a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="denyMembersManagement"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="guestEmail"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIGuest>> CreateProjectGuestAsync(
            string projectId,
            global::Dataloop.GuestType type,
            string name,
            string guestEmail,
            bool? denyMembersManagement = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}