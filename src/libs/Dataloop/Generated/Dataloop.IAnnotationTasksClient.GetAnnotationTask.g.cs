#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationTasksClient
    {
        /// <summary>
        /// Get a specific task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get a Task object to use in your code.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer* or *annotation manager* who has been assigned the task.<br/>
        /// # <br/>
        /// # :param str task_name: optional - search by name<br/>
        /// # :param str task_id: optional - search by id<br/>
        /// # :return: task object<br/>
        /// # :rtype: dtlpy.entities.task.Task<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset.tasks.get(task_id='task_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APITask> GetAnnotationTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}