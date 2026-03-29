#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Change a member's role in a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// user_json = = dl.projects.update_member(project_id='project_id', email='user@dataloop.ai', role=dl.MemberRole.DEVELOPER)<br/>
        /// # <br/>
        /// # Update member's information/details in the project.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* to update a member.<br/>
        /// # <br/>
        /// # :param str email: member email<br/>
        /// # :param str project_id: The Id of the project<br/>
        /// # :param role: The required role for the user. Use the enum dl.MemberRole<br/>
        /// # :return: dict that represent the user<br/>
        /// # :rtype: dict<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>> ChangeMemberProjectRoleAsync(
            string projectId,
            string userId,

            global::Dataloop.PatchMemberPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a member's role in a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="denyMembersManagement"></param>
        /// <param name="role"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>> ChangeMemberProjectRoleAsync(
            string projectId,
            string userId,
            global::Dataloop.Role role,
            bool? denyMembersManagement = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}