#nullable enable

namespace Dataloop
{
    public partial interface IItemAnnotationsClient
    {
        /// <summary>
        /// List all annotations of an item
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>> ListItemAnnotationsAsync(
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}