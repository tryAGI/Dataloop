#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationTasksClient
    {
        /// <summary>
        /// Get counters for project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.WorkflowsCounters> GetCountersForProjectAsync(
            string projectId,

            global::Dataloop.GetCountersForProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get counters for project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="contributors"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.WorkflowsCounters> GetCountersForProjectAsync(
            string projectId,
            global::System.Collections.Generic.IList<string>? contributors = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}