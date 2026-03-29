#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationTasksClient
    {
        /// <summary>
        /// Get all actions(statuses) related to the required dataset
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.ItemAction>> GetDatasetActionsAsync(
            string projectId,
            string datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}