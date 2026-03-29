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
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> SplitMlOperationAsync(
            string id,

            global::Dataloop.SplitMlOperationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mLSplitList">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="itemsQuery"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> SplitMlOperationAsync(
            string id,
            global::Dataloop.RecordMLSplitListKeysNumber mLSplitList,
            global::Dataloop.DQLResourceQuery itemsQuery,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}