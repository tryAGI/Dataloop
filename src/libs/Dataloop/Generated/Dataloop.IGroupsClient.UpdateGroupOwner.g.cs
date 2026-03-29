#nullable enable

namespace Dataloop
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Update the group's owner
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIGroup> UpdateGroupOwnerAsync(
            string groupId,

            global::Dataloop.UpdateGroupOwnerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the group's owner
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="newGroupOwnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIGroup> UpdateGroupOwnerAsync(
            string groupId,
            string newGroupOwnerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}