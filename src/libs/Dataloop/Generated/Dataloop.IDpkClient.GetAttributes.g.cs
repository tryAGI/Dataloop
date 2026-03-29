#nullable enable

namespace Dataloop
{
    public partial interface IDpkClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.DpkAttributesDefinition>> GetAttributesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}