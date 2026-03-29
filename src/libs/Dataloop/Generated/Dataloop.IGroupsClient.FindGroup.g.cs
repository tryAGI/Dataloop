#nullable enable

namespace Dataloop
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Get a group by id
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIGroup> FindGroupAsync(
            string groupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}