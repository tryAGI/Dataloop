#nullable enable

namespace Dataloop
{
    public partial interface IItemAnnotationsClient
    {
        /// <summary>
        /// Get annotation by id
        /// </summary>
        /// <param name="annotationId"></param>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAnnotation> GetItemAnnotationAsync(
            string annotationId,
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}