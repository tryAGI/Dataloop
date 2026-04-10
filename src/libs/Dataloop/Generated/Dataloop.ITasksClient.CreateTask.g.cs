#nullable enable

namespace Dataloop
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Create a new Task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>> CreateTaskAsync(

            global::Dataloop.TaskPayload request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new Task
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="recipeId"></param>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="taskOwner"></param>
        /// <param name="dueDate"></param>
        /// <param name="query"></param>
        /// <param name="status"></param>
        /// <param name="assignmentIds"></param>
        /// <param name="spec"></param>
        /// <param name="workload"></param>
        /// <param name="limit"></param>
        /// <param name="percentage"></param>
        /// <param name="asynced"></param>
        /// <param name="emptyTask"></param>
        /// <param name="checkIfExist"></param>
        /// <param name="availableActions"></param>
        /// <param name="disableWebm"></param>
        /// <param name="metadata"></param>
        /// <param name="priority"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>> CreateTaskAsync(
            string datasetId,
            string recipeId,
            string projectId,
            string name,
            string taskOwner,
            string query,
            global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec> spec,
            double? dueDate = default,
            string? status = default,
            global::System.Collections.Generic.IList<string>? assignmentIds = default,
            global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? workload = default,
            double? limit = default,
            bool? percentage = default,
            bool? asynced = default,
            bool? emptyTask = default,
            global::Dataloop.TaskPayloadCheckIfExist? checkIfExist = default,
            global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? availableActions = default,
            bool? disableWebm = default,
            global::Dataloop.TaskMetadata? metadata = default,
            double? priority = default,
            global::Dataloop.PickDescriptionContent? description = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}