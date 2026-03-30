#nullable enable

namespace Dataloop
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// Delete Package object.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePackagesAsync(
            string ids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}