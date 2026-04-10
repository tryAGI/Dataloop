#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get all my projects
        /// </summary>
        /// <param name="excludeContributors"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get the user's project list<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be a **superuser** to list all users' projects.<br/>
        /// # <br/>
        /// # :return: List of Project objects<br/>
        /// # <br/>
        /// # <br/>
        /// # projects = dl.projects.list()<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIProject>> GetMyProjectsAsync(
            bool? excludeContributors = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}