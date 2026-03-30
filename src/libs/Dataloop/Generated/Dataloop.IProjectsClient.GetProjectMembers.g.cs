#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project's members
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get a list of the project members.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* to list project members.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.project.Project project: Project object<br/>
        /// # :param role: The required role for the user. Use the enum dl.MemberRole<br/>
        /// # :return: list of the project members<br/>
        /// # :rtype: list<br/>
        /// # <br/>
        /// # <br/>
        /// # users_jsons_list = dl.projects.list_members(project_id='project_id', role=dl.MemberRole.DEVELOPER)<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIUser>> GetProjectMembersAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}