#nullable enable

namespace Dataloop
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Update an existing task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APITask> UpdateTaskAsync(
            string id,

            global::Dataloop.PartialTaskPayload request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipeId"></param>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="creator"></param>
        /// <param name="taskOwner"></param>
        /// <param name="priority"></param>
        /// <param name="dueDate"></param>
        /// <param name="status"></param>
        /// <param name="availableActions"></param>
        /// <param name="spec"></param>
        /// <param name="metadata"></param>
        /// <param name="asynced"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APITask> UpdateTaskAsync(
            string id,
            global::Dataloop.Dictionary metadata,
            string? recipeId = default,
            string? query = default,
            string? name = default,
            string? creator = default,
            string? taskOwner = default,
            double? priority = default,
            double? dueDate = default,
            string? status = default,
            global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? availableActions = default,
            global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>? spec = default,
            bool? asynced = default,
            global::Dataloop.PickDescriptionContent? description = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}