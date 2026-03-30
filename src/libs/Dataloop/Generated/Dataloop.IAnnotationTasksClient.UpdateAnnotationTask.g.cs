#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationTasksClient
    {
        /// <summary>
        /// Update an existing task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update a Task.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer* or *annotation manager* who created that task.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.task.Task task: the task object<br/>
        /// # :param bool system_metadata: DEPRECATED<br/>
        /// # :return: Task object<br/>
        /// # :rtype: dtlpy.entities.task.Task<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset.tasks.update(task='task_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APITask> UpdateAnnotationTaskAsync(
            string id,

            global::Dataloop.PartialTaskPayload request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APITask> UpdateAnnotationTaskAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}