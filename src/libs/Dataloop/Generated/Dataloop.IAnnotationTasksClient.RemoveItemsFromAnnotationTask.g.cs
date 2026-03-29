#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationTasksClient
    {
        /// <summary>
        /// Remove work from an existing Task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APITask>> RemoveItemsFromAnnotationTaskAsync(
            string id,

            global::Dataloop.RemoveFromTaskPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove work from an existing Task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="query"></param>
        /// <param name="asynced"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APITask>> RemoveItemsFromAnnotationTaskAsync(
            string id,
            string query,
            bool? asynced = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}