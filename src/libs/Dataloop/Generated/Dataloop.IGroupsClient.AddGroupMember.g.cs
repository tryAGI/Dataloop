#nullable enable

namespace Dataloop
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Add a member to a group
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.AuthUserAttributes>> AddGroupMemberAsync(
            string groupId,

            global::Dataloop.AddGroupMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a member to a group
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.AuthUserAttributes>> AddGroupMemberAsync(
            string groupId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}