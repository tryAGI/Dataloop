#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Delete a project forever!<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* to delete a project.<br/>
        /// # <br/>
        /// # :param str project_name: optional - search by name<br/>
        /// # :param str project_id: optional - search by id<br/>
        /// # :param bool sure: Are you sure you want to delete?<br/>
        /// # :param bool really: Really really sure?<br/>
        /// # :return: True if success, error if not<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # is_deleted = dl.projects.delete(project_id='project_id', sure=True, really=True)<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task DeleteProjectAsync(
            string projectId,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}