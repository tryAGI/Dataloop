#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Change a project's name
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update a project information (e.g., name, member roles, etc.).<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* to add a member to a project.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.project.Project project: project object<br/>
        /// # :param bool system_metadata: optional - True, if you want to change metadata system<br/>
        /// # :return: Project object<br/>
        /// # :rtype: dtlpy.entities.project.Project<br/>
        /// # <br/>
        /// # <br/>
        /// # project = dl.projects.delete(project='project_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIProject> PatchProjectAsync(
            string projectId,

            global::Dataloop.PatchProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a project's name
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIProject> PatchProjectAsync(
            string projectId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}