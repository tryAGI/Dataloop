#nullable enable

namespace Dataloop
{
    public partial interface IDpkClient
    {
        /// <summary>
        /// Get the dpk requirements for install.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Dictionary> GetDpkRequirementsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}