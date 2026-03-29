#nullable enable

namespace Dataloop
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Update a groups name
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIGroup> UpdateGroupAsync(
            string groupId,

            global::Dataloop.PatchGroupPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a groups name
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="name"></param>
        /// <param name="defaultProjectRole"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIGroup> UpdateGroupAsync(
            string groupId,
            string name,
            bool? defaultProjectRole = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}