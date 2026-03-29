#nullable enable

namespace Dataloop
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// For org admin / owner:<br/>
        /// Get active counters for projects
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APITaskCounters> GetProjectsActiveCountersAsync(

            global::Dataloop.GetProjectsActiveCountersRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// For org admin / owner:<br/>
        /// Get active counters for projects
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="projectIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APITaskCounters> GetProjectsActiveCountersAsync(
            global::System.Collections.Generic.IList<string> projectIds,
            string? datasetId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}