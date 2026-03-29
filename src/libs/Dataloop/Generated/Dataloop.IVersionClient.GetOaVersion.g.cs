#nullable enable

namespace Dataloop
{
    public partial interface IVersionClient
    {
        /// <summary>
        /// Retrieves the latest OA versions.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.IVersion> GetOaVersionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}