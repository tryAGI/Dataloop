#nullable enable

namespace Dataloop
{
    public partial interface IOntologiesClient
    {
        /// <summary>
        /// Delete a bulk of attributes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAttributesAsync(
            string id,

            global::Dataloop.DeleteAttributesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a bulk of attributes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteAttributesAsync(
            string id,
            global::System.Collections.Generic.IList<string> keys,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}