#nullable enable

namespace Dataloop
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Remove a member from a group
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="memberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveGroupMemberAsync(
            string groupId,
            string memberId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}