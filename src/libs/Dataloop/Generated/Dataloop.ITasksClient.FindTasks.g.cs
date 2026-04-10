#nullable enable

namespace Dataloop
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Find tasks by query
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="dataset"></param>
        /// <param name="recipe"></param>
        /// <param name="status"></param>
        /// <param name="creator"></param>
        /// <param name="taskOwner"></param>
        /// <param name="name"></param>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        /// <param name="assignments"></param>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentTaskId"></param>
        /// <param name="type"></param>
        /// <param name="archive"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APITaskCursor> FindTasksAsync(
            global::System.Collections.Generic.IList<string>? projects = default,
            string? dataset = default,
            string? recipe = default,
            string? status = default,
            string? creator = default,
            string? taskOwner = default,
            string? name = default,
            double? minDate = default,
            double? maxDate = default,
            global::System.Collections.Generic.IList<string>? assignments = default,
            double? pageOffset = default,
            double? pageSize = default,
            string? parentTaskId = default,
            string? type = default,
            bool? archive = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}