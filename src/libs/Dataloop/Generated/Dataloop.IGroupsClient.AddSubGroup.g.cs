#nullable enable

namespace Dataloop
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Add a group as a child group to another group.<br/>
        /// If the parent group has a role in a project, the child group members will inherit that role.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>> AddSubGroupAsync(
            string groupId,

            global::Dataloop.AddSubGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a group as a child group to another group.<br/>
        /// If the parent group has a role in a project, the child group members will inherit that role.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="subGroupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>> AddSubGroupAsync(
            string groupId,
            string subGroupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}