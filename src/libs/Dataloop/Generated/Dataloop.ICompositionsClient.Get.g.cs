#nullable enable

namespace Dataloop
{
    public partial interface ICompositionsClient
    {
        /// <summary>
        /// Get an composition updated object from the db.
        /// </summary>
        /// <param name="compositionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIComposition> GetAsync(
            string compositionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}