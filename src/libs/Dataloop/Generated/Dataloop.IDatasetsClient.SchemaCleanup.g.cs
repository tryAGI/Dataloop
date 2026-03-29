#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> SchemaCleanupAsync(

            global::Dataloop.SchemaCleanupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> SchemaCleanupAsync(
            global::Dataloop.DQLResourceQuery query,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}