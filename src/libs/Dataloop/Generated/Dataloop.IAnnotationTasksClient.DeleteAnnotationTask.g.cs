#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationTasksClient
    {
        /// <summary>
        /// Delete a task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// dataset.tasks.delete(task_id='task_id')<br/>
        /// # <br/>
        /// # Delete the Task.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer* or *annotation manager* who created that task.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.task.Task task: the task object<br/>
        /// # :param str task_name: the name of the task<br/>
        /// # :param str task_id: the Id of the task<br/>
        /// # :param bool wait: wait until delete task finish<br/>
        /// # :return: True is success<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<object, global::Dataloop.APICommand>> DeleteAnnotationTaskAsync(
            string id,

            global::Dataloop.DeleteTaskPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="asynced"></param>
        /// <param name="deleteWithPipeline"></param>
        /// <param name="emptyOnly"></param>
        /// <param name="force"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<object, global::Dataloop.APICommand>> DeleteAnnotationTaskAsync(
            string id,
            bool? asynced = default,
            bool? deleteWithPipeline = default,
            bool? emptyOnly = default,
            bool? force = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}