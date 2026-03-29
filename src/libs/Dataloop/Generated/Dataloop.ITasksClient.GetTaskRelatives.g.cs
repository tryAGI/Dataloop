#nullable enable

namespace Dataloop
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Get the relative task names of a specific task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.TaskRelativeInput>> GetTaskRelativesAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}