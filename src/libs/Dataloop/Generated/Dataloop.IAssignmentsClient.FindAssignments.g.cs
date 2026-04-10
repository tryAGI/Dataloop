#nullable enable

namespace Dataloop
{
    public partial interface IAssignmentsClient
    {
        /// <summary>
        /// Find assignments by query
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projects"></param>
        /// <param name="annotator"></param>
        /// <param name="status"></param>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="taskId"></param>
        /// <param name="active"></param>
        /// <param name="archive"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAssignmentCursor> FindAssignmentsAsync(
            string? name = default,
            global::System.Collections.Generic.IList<string>? projects = default,
            string? annotator = default,
            string? status = default,
            double? pageOffset = default,
            double? pageSize = default,
            string? taskId = default,
            bool? active = default,
            bool? archive = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}