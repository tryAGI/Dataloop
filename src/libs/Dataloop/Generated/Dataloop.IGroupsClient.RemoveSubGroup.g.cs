#nullable enable

namespace Dataloop
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Remove a group as a child group from another group.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="subGroupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveSubGroupAsync(
            string groupId,
            string subGroupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}