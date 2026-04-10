#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Add a single member to a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="allowUpdate"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Add a member to the project.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* to add a member to a project.<br/>
        /// # <br/>
        /// # :param str email: member email<br/>
        /// # :param str project_id: The Id of the project<br/>
        /// # :param role: The required role for the user. Use the enum dl.MemberRole<br/>
        /// # :return: dict that represent the user<br/>
        /// # :rtype: dict<br/>
        /// # <br/>
        /// # <br/>
        /// # user_json = dl.projects.add_member(project_id='project_id', email='user@dataloop.ai', role=dl.MemberRole.DEVELOPER)<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>> AddMemberToProjectAsync(
            string projectId,
            string userId,

            global::Dataloop.AddMemberPayload request,
            bool? allowUpdate = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a single member to a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="allowUpdate"></param>
        /// <param name="via"></param>
        /// <param name="denyMembersManagement"></param>
        /// <param name="canAddGroups"></param>
        /// <param name="skipWelcomeEmail"></param>
        /// <param name="skipResponse"></param>
        /// <param name="role"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>> AddMemberToProjectAsync(
            string projectId,
            string userId,
            global::Dataloop.Role role,
            bool? allowUpdate = default,
            string? via = default,
            bool? denyMembersManagement = default,
            bool? canAddGroups = default,
            bool? skipWelcomeEmail = default,
            bool? skipResponse = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}