#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Remove a member from a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// user_json = dl.projects.remove_member(project_id='project_id', email='user@dataloop.ai')<br/>
        /// # <br/>
        /// # Remove a member from the project.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* to delete a member from a project.<br/>
        /// # <br/>
        /// # :param str email: member email<br/>
        /// # :param str project_id: The Id of the project<br/>
        /// # :return: dict that represents the user<br/>
        /// # :rtype: dict<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>> RemoveMemberFromProjectAsync(
            string projectId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}