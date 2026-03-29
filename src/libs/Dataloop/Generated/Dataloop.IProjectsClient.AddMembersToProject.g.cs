#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// add multiple members to a project with a given role
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIMembership>, object>> AddMembersToProjectAsync(
            string projectId,

            global::Dataloop.AddMembersBatchPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// add multiple members to a project with a given role
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="interest"></param>
        /// <param name="via"></param>
        /// <param name="denyMembersManagement"></param>
        /// <param name="skipResponse"></param>
        /// <param name="skipWelcomeEmail"></param>
        /// <param name="role"></param>
        /// <param name="users"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIMembership>, object>> AddMembersToProjectAsync(
            string projectId,
            global::Dataloop.Role role,
            global::System.Collections.Generic.IList<string> users,
            global::Dataloop.UserInterestType? interest = default,
            string? via = default,
            bool? denyMembersManagement = default,
            bool? skipResponse = default,
            bool? skipWelcomeEmail = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}