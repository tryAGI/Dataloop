#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Add a group to a project with a given role
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>> AddGroupAsync(
            string projectId,
            string groupId,

            global::Dataloop.AddGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a group to a project with a given role
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="groupId"></param>
        /// <param name="role"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>> AddGroupAsync(
            string projectId,
            string groupId,
            global::Dataloop.Role role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}