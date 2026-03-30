#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Creates a new project
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create a new project.<br/>
        /// # <br/>
        /// # **Prerequisites**: Any user can create a project.<br/>
        /// # <br/>
        /// # :param str project_name: The Name of the project<br/>
        /// # :param bool checkout: set the project as a default project object (cookies)<br/>
        /// # :return: Project object<br/>
        /// # :rtype: dtlpy.entities.project.Project<br/>
        /// # <br/>
        /// # <br/>
        /// # project = dl.projects.create(project_name='project_name')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIProject> CreateProjectAsync(

            global::Dataloop.CreateProjectPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new project
        /// </summary>
        /// <param name="account"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIProject> CreateProjectAsync(
            string name,
            string? account = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}