#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Add or remove Cache for the org.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task CacheAsync(
            global::Dataloop.ECacheMode mode,

            global::Dataloop.ICacheOptions request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add or remove Cache for the org.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="org"></param>
        /// <param name="driverId"></param>
        /// <param name="runner"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CacheAsync(
            global::Dataloop.ECacheMode mode,
            global::Dataloop.ICacheOptionsOrg org,
            string? driverId = default,
            global::Dataloop.ICacheRunner? runner = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}