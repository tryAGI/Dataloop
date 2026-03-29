#nullable enable

namespace Dataloop
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// Retrieves scores for a specific task annotation.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="annotationId"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.GetTaskAnnotationScoresResponse> GetTaskAnnotationScoresAsync(
            string taskId,
            string annotationId,
            double? page = default,
            double? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}