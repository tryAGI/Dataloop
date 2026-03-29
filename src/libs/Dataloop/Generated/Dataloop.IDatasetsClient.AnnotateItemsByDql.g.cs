#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task AnnotateItemsByDqlAsync(
            string id,

            global::Dataloop.ClassifyFilteredItems request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="query"></param>
        /// <param name="annotation"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AnnotateItemsByDqlAsync(
            string id,
            global::Dataloop.ClassifyFilteredItemsQuery query,
            global::Dataloop.ClassifyFilteredItemsAnnotation annotation,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}