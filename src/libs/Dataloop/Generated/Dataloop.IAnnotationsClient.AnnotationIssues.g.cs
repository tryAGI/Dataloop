#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Update an item's annotation status to issue
        /// </summary>
        /// <param name="annotationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAnnotation> AnnotationIssuesAsync(
            string annotationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}