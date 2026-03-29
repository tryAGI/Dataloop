#nullable enable

namespace Dataloop
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Get a specific task's queue details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.TaskQueueDetails> GetTaskQueueDetailsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}