#nullable enable

namespace Dataloop
{
    public partial interface IServiceDriversClient
    {
        /// <summary>
        /// Set Service Driver.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIServiceDriver> SetDefaultAsync(

            global::Dataloop.SetDefaultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Service Driver.
        /// </summary>
        /// <param name="driverName"></param>
        /// <param name="organizationId"></param>
        /// <param name="updateExistingServices"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIServiceDriver> SetDefaultAsync(
            string driverName,
            string organizationId,
            bool? updateExistingServices = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}