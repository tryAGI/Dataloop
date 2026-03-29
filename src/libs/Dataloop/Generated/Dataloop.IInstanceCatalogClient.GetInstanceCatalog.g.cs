#nullable enable

namespace Dataloop
{
    public partial interface IInstanceCatalogClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetInstanceCatalogAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}