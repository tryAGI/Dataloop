#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Returns details of a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get a Project object.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* to get a project object.<br/>
        /// # <br/>
        /// # You must check out to a project or provide at least one of the following params: project_id, project_name<br/>
        /// # <br/>
        /// # :param str project_name: optional - search by name<br/>
        /// # :param str project_id: optional - search by id<br/>
        /// # :param bool checkout: set the project as a default project object (cookies)<br/>
        /// # :param bool fetch: optional - fetch entity from platform (True), default taken from cookie<br/>
        /// # :param bool log_error: optional - show the logs errors<br/>
        /// # :return: Project object<br/>
        /// # :rtype: dtlpy.entities.project.Project<br/>
        /// # <br/>
        /// # <br/>
        /// # project = dl.projects.get(project_id='project_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIProject> GetProjectAsync(
            string projectId,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}