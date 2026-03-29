#nullable enable

namespace Dataloop
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// create a new group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIGroup> CreateGroupAsync(

            global::Dataloop.CreateGroupPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// create a new group
        /// </summary>
        /// <param name="name"></param>
        /// <param name="orgId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIGroup> CreateGroupAsync(
            string name,
            string orgId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}