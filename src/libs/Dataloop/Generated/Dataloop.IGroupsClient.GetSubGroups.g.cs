#nullable enable

namespace Dataloop
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Get all subgroups of a group
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>> GetSubGroupsAsync(
            string groupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}