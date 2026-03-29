#nullable enable

namespace Dataloop
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteScoresAsync(

            global::Dataloop.DeleteTaskItemScoresPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteScoresAsync(
            global::Dataloop.DeleteTaskItemScoresPayloadContext context,
            string? entityId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}