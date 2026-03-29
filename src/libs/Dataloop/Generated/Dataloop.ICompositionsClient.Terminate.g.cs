#nullable enable

namespace Dataloop
{
    public partial interface ICompositionsClient
    {
        /// <summary>
        /// Delete the composition. delete all the entities
        /// </summary>
        /// <param name="compositionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TerminateAsync(
            string compositionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}